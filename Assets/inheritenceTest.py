class grand:
    def my_print(self):
        print("test grand")

class father(grand):
    pass

class child (father):
    pass

if __name__ == "__main__":
    ch = child()
    ch.my_print()