def suma(a, b):
    print("\nLa suma es: ",a+b)

def resta(a, b):
    print("\nLa resta es: ",a+b)

def multi(a, b):
    print("\nLa multiplicación es: ",a*b)

def divi(a, b):
    if b != 0:
        print("\nLa división es: ", a/b)
    else: print("No se puede dividir entre 0")

def operaciones():
    while True:
        print("Bienvenido al sistema de calculadora")
        print("\n1. Suma")
        print("2. Resta")
        print("3. Multiplicación")
        print("4. División")

        opc = int(input("\nSeleccione una opción: "))

        a = int(input("\nIngrese el primer número: "))
        b = int(input("Ingrese el segundo número: "))

        match opc:
            case 1: suma(a,b)
            case 2: resta(a,b)
            case 3: multi(a,b)
            case 4: divi(a,b)
            case _: 
                print("Opción no valida. Intente de nuevo.")
                continue

        conti = input("\n¿Desea continuar? Presione (y): ")

        if conti != "y":
            print("\nPrograma finalizado!")
            break

operaciones()

