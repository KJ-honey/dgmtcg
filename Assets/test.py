
class human:
    bornNum = 900
    def __new__(cls):
        print('new')
        return super().__new__(cls)
    def bornPlus(self):
        human.bornNum+=1
    def printBorn(self):
        print(self.bornNum)
def main():
    humanInstence = human()
    InsTest=human()
    #print(humanInstence.bornNum)
    humanInstence.printBorn()

    humanInstence.bornPlus()
    humanInstence.printBorn()
    InsTest.printBorn()
    InsTest.bornPlus()

    print(human.bornNum)
if __name__ == "__main__":
    main()

