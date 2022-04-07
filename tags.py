from tkinter import *
import re


def find_sum(str1):
    return sum(map(int, re.findall('\d', str1)))

def text_to_bits(text, encoding='utf-8', errors='surrogatepass'):
    bits = bin(int.from_bytes(text.encode(encoding, errors), 'big'))[2:]
    return bits.zfill(8 * ((len(bits) + 7) // 8))

class MyWindow:
    def __init__(self, win):
        self.lbl1=Label(win, text='Enter text')
        self.lbl2=Label(win, text='Enter adders')
        self.lbl3=Label(win, text='Result')
        self.t1=Entry()
        self.t2=Entry()
        self.t3=Text()
        self.btn1 = Button(win, text='Encode')
        self.btn2=Button(win, text='Decode')
        self.lbl1.place(x=10, y=10)
        self.t1.place(x=100, y=10)
        self.lbl2.place(x=10, y=60)
        self.t2.place(x=100, y=60)
        self.b1=Button(win, text='Encode', command=self.encode)
        self.b2=Button(win, text='Decode')
        self.b2.bind('<Button-1>', self.decode)
        self.b1.place(x=60, y=110)
        self.b2.place(x=130, y=110)
        self.lbl3.place(x=10, y=160)
        self.t3.place(x=100, y=160, width=125, height=70)

    def encode(self):
        self.t3.delete(1.0, END)
        #text = self.t1.get()
        text = text_to_bits(self.t1.get()) 
        nonarray = self.t2.get()
        array = nonarray.split(" ")

        rez = ""
        value =""
        string0 = "0" * len(text)
        for i in range (len(text)):
            string0 = text[0:1:1] + string0[:-1:]
            text = text[1:]
            print("\n")
            print("Исходная строка " + string0)
            print("\n")
            stringlist = list(string0)
            sums = list(array)
            for i in range (len(sums)): # 3 times
                regs = list(sums[i])
                for i in range (len(regs)):
                    print("Номер региста " + regs[i])
                    rez = rez + stringlist[int(regs[i])]
                    print("Значение строки " + stringlist[int(regs[i])])
                    print("результат сложения rez "+ rez)
                answerdigit = find_sum(rez) % 2
                rez =""
                print("Сложение по модулю " + str(answerdigit))
                value = value + str(answerdigit)
                print("___________________________")
        print(value)
        self.t3.insert(END, value)

    def decode(self, event):
        self.t3.delete(1.0, END)
        text = self.t1.get()
        self.t3.insert(END, text)
 
def decode(self, data: list[int]) -> (bytes, int):
        """
        decode data bytes
        :param data: coded data to be decoded, list of ints representing each received bit.
        :return: return a tuple of decoded data, and the amount of corrected errors.
        :rtype: (bytes, int)

        The function assumes initial and final state of encoder was at the zero state
        """
        received_codewords = [tuple(data[i: i+self.n]) for i in range(0, len(data), self.n)]
        surviving_paths = [TrellisPath()]

        for codeword in received_codewords:  # iterate over time (received codewords)
            # obtain branch metrics
            possible_transitions = []
            # find branch metrics
            for path in surviving_paths:
                for possible_input in range(2**self.k):
                    # for each path and possible input find possible output, and branch metric
                    last_state = path.last_state()
                    next_state = self.next_states[last_state][possible_input]
                    possible_output = self.out_bits[last_state][possible_input]
                    branch_metric = sum(tuple(possible_output[i]^codeword[i] for i in range(len(codeword))))
                    possible_transitions.append([next_state, branch_metric + path.path_metric(), branch_metric, path,
                                                 possible_input])

            # select survivors by inspecting paths entering a state
            new_paths = []
            for state in self.state_space:
                entering_paths = tuple(filter(lambda x: x[0] == state, possible_transitions))
                # initially there may be less paths than states, since we assume initialization at zero state
                if len(entering_paths):
                    selected = min(entering_paths, key=lambda x: x[1])
                    selected_path: TrellisPath = selected[3]
                    new_path = TrellisPath.duplicate_path(selected_path)
                    new_path.add_2_path(state, selected[2], selected[4])
                    new_paths.append(new_path)
            surviving_paths = new_paths

        # choose ML path
        chosen_path = None
        for path in surviving_paths:
            if path.last_state() == 0:  # as a result of zero tailing
                chosen_path = path
                break
        if chosen_path is None:
            raise DecodingError

        decoded_bits = chosen_path.input_bits()[1:-int(self.constraint_length)]
        mapped = "".join(map(str, decoded_bits))
        decoded_bytes = bytes([int(mapped[i:i + 8], 2) for i in range(0, len(mapped), 8)])
        chosen_path.path_metric()
        return decoded_bytes, chosen_path.path_metric()

 
window=Tk()
mywin=MyWindow(window)
window.title('ConvolutionalCoder')
window.geometry("250x250")
window.mainloop()