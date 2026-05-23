print("Kalkulator")

a = float(input("Podaj pierwsza liczbe: "))
b = float(input("Podaj druga liczbe: "))

znak = input("Podaj dzialanie (+, -, *, /): ")

if znak == "+":
    print("Wynik =", a + b)

elif znak == "-":
    print("Wynik =", a - b)

elif znak == "*":
    print("Wynik =", a * b)

elif znak == "/":
    print("Wynik =", a / b)

else:
    print("Bledne dzialanie")