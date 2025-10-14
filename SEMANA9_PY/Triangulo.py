class Triangulo:
    
    def area(self) -> None:
        b = int(input("\nIngresa la base: "))
        h = int(input("Ingrese la altura: "))
        print("\nÁrea: ",((b*h)/2))
    
    def perimetro(self)->None:
        l1 = int(input("\nIngrese lado 1: "))
        l2 = int(input("Ingrese lado 2: "))
        l3 = int(input("Ingrese lado 3: "))
        print("\nPerímetro: ", (l1+l2+l3))