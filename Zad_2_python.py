print("Konwerter temperatur")

wybor = input("Wybierz C lub F: ")

if wybor == "C":
    c = float(input("Podaj temperature w Celsjuszach: "))
    f = c * 1.8 + 32
    print("Temperatura w Fahrenheitach =", f)

elif wybor == "F":
    f = float(input("Podaj temperature w Fahrenheitach: "))
    c = (f - 32) / 1.8
    print("Temperatura w Celsjuszach =", c)

else:
    print("Bledny wybor")
