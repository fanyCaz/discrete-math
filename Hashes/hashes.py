import math

#a hash function must be deterministic: never return different values with each call
#the keys are inmutable: you can't change them

class Person():
    """
    Tipo Persona
    """
    def __init__(self, name:str,sex:str,age:int):
        self.name = name
        self.sex = sex
        self.age = age

#maps a key (x) to a number in a fixed range, it means return a value related to this 'x'
def basicHashFunc(x:int)->int:
    sqr = math.pow(x,2)
    mult =(6*x)
    const = 9
    return (sqr - mult + const) % 10

def chHashFunc(persona):
    xx = 0
    if persona.sex == 'F':
        xx = 1
    return (len(persona.name) + xx* persona.age) % 5

print(basicHashFunc(8))

will = Person('Kate','F',25)
print(chHashFunc(will))