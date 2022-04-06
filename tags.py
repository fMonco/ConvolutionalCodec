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
        self.lbl3=Label(win, text='Encoded')
        self.t1=Entry(bd=3)
        self.t2=Entry()
        self.t3=Entry()
        self.btn1 = Button(win, text='Encode')
        self.btn2=Button(win, text='Decode')
        self.lbl1.place(x=100, y=50)
        self.t1.place(x=200, y=50)
        self.lbl2.place(x=100, y=100)
        self.t2.place(x=200, y=100)
        self.b1=Button(win, text='Encode', command=self.encode)
        self.b2=Button(win, text='Decode')
        self.b2.bind('<Button-1>', self.decode)
        self.b1.place(x=100, y=150)
        self.b2.place(x=200, y=150)
        self.lbl3.place(x=100, y=200)
        self.t3.place(x=200, y=200)


    def encode(self):
        self.t3.delete(0, 'end')
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
        self.t3.delete(0, 'end')
        self.t3.insert(END, text)
 


 
window=Tk()
mywin=MyWindow(window)
window.title('ConvolutionalCoder')
window.geometry("400x300+10+10")
window.mainloop()