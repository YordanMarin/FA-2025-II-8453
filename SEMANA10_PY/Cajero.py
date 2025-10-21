class Cajero:

    saldo = 1000

    def consultar(self) -> float:
        return self.saldo

    def depositar(self, monto) -> None:
        while True:
            try:
                m = float(monto)

                if m > 0:
                    self.saldo += m
                    print("\nDepósito exitoso.")
                    break
                else:
                    print("\nError. El monto a depositar debe de ser mayor a 0")
                    break

            except ValueError:
                print("\nError. Solo se permiten números")
                break

    def retirar(self, monto) -> None:
        while True:
            try:
                m = float(monto)

                if m > self.saldo:
                    print("\nError. No tiene suficiente saldo.")
                    break
                elif m<=0:
                    print("\nError. El monto a retirar debe de ser mayor a 0.")
                    break
                else:
                    self.saldo -= m
                    print("Retiro exitoso.")
                    break

            except ValueError:
                print("\nError. Solo se permiten números")
                break
