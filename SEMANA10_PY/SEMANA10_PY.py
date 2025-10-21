from Cajero import Cajero
c= Cajero()

conti = "s"

while conti =="s":
    print("BIEVENIDOS AL SISTEMA CAJERO\n")
    print("1. Consultar saldo")
    print("2. Depositar dinero")
    print("3. Retirar dinero.")
    print("4. Salir\n")

    while True:
        opc = int(input("Ingrese una opción: "))

        if opc in (1,2,3,4): break
        else: print("Opción no valida. Ingrese nuevamente.\n")

    match opc:
        case 1: print("\nSaldo disponible: ",c.consultar())
        case 2: 
            monto = input("\nIngrese el monto a depositar: ")
            c.depositar(monto)
        case 3: 
            monto = input("\nIngrese el monto a retirar: ")
            c.retirar(monto)
        case 4: quit()

    while True:
        conti = input("\n¿Deses continuar? (s/n): ").lower().strip()

        if conti in ("s", "n"): break
        else: print("Opción no valida. Presione solo 's' o 'n'")
