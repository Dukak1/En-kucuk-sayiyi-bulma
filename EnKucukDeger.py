def min_(x):
    enKucuk = x[0]

    for eleman in x:
        if eleman < enKucuk:
            enKucuk = eleman

    return enKucuk

s1 = int(input("1. sayı: "))
s2 = int(input("2. sayı: "))
s3 = int(input("3. sayı: "))

liste = [s1, s2, s3]

result = min_(liste)
print(result)
