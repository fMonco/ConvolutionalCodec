import re

def find_sum(str1):
    return sum(map(int, re.findall('\d', str1)))

text = "1101"
array = ["012", "02"]
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