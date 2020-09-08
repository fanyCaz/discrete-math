

#cuantificador existencial ∃
def cuantificadorExistencial(x):
    for val in x:
        px = val/(val**2 + 1)
        if px == 2/5:
            print(val)
            return True
    return False

def afirmacionCuantificada(x):
    for val in x:
        px = 1/(val**2 + 1)
        if px > 1:
            print(val)
            return True    #si para al menos una, entonces todo es verdadero
    return False

x = [i for i in range(1,100)]

print( cuantificadorExistencial(x) )

print( afirmacionCuantificada(x) )