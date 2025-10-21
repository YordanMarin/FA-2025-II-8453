from Triangulo import Triangulo
from Cuadrado import Cuadrado

c= Cuadrado()
t = Triangulo()

def menu1() -> None:
    print("BIENVENIDOS A CALCULOS DE ÁREAS Y PERÍMETROS\n")
    print("******** Menú de opciones *********")
    print("*    1. Triángulo                 *")
    print("*    2. Cuadrado                  *")
    print("*    3. Rectángulo                *")
    print("*    4. Trapecio                  *")
    print("*    0. Salir                     *")
    print("***********************************\n")

def menu2() -> int:
    print("\n********************")
    print("*    1. Área       *")
    print("*    2. Perímetro  *")
    print("********************\n")

    opcion2 = int(input("Ingrese opción: "))
    return opcion2

while True:
    menu1()
    while True:
        opcion = int(input("Ingrese opción: "))
        if opcion in (0,1,2,3,4):
            break
        else: print("Opción no valida. Ingrese nuevamente.\n")

    match opcion:
        case 0: quit() #exit()
        case 1: 
            opc2 = menu2()
            match opc2:
                case 1: t.area()
                case 2: t.perimetro()

        case 2: print()
        case 3: print()
        case 4: print()
    
    while True:
        conti = input("\n¿Desea continuar? (s/n): ")
        if conti in("s", "n"): break
        else: print("Error. Presionse solo 's' o 'n'.")
    
    if conti =="n": break
   




