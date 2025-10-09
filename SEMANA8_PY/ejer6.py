dolar = 3.78
euro = 4.20

def convertir():
    while True:
        print("Bienvenido al conversor de monedas")
        print("\n1. Dólares")
        print("2. Euros")
        print("3. Salir")

        opc = int(input("\nIngrese una opción: "))

        soles = float(input("\nIngrese el monto en soles: "))

        match opc:
            case 1: 
                conv_d = soles/dolar
                print("\nConversión a dolar: ",round(conv_d))
            case 2:
                conv_e = soles/euro
                print("\nConversión a euros: ",round(conv_e))
            case 3:
                print("Saliendo del programa...")
                break
            case _:
                print("Opción no válida")
                continue

        conti = input("\n¿Desea continuar? precione (y): ")
        if conti != "y":
            print("Programa finalizado!")
            break

convertir()
