lado1 = int(input("Ingrese lado 1: "))
lado2 = int(input("Ingrese lado 2: "))
lado3 = int(input("Ingrese lado 3: "))

print()

if lado1 == lado2 == lado3:
    print("Triangulo equilátero")
elif lado1==lado2 or lado2 == lado3 or lado1 ==lado3:
    print("Triangulo isósceles")
else:
    print("Triangulo escaleno")