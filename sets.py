def cardinality(Set):   #size of set
    return len(Set)

def addToSetEvens(Set, element): #to belong it must be even and less or equal than 10
    if element <= 10 and element%2 == 0:
        Set.add(element)
    return Set

def cartesianProduct(set1, set2):
    print("There will be {} elements from this Cartesian Product {},{}".format(len(set1)*len(set2),set1,set2))
    for x in set1:
        for y in set2:
            print("({},{})".format(x,y))

def cartesianProductThreeElements(set1,set2,set3):
    print("There will be {} elements from this Cartesian Product {} {} {}".format(len(set1)*len(set2)*len(set3),set1,set2,set3))
    for x in set1:
        for y in set2:
            for z in set3:
                print("({},{},{})".format(x,y,z))

#for every x, if x belongs to A , then x belongs to B, if x belongs to B, then x belongs to A
def equalSets(set1,set2): 
    for x in set1:
        if x not in set2:
            return False
    for x in set2:
        if x not in set1:
            return False
    return True

def subsetOfSet(subset,superset):  #A subset of B
    if subset == superset: #Es un subconjunto
        return True
    for x in subset:
        if x in superset:   #if one x is in the superset, then A is part of B
            return True
    return False

# zip function         https://www.geeksforgeeks.org/zip-in-python/
# bitwise << operator  https://www.geeksforgeeks.org/python-bitwise-operators/
def PowerSet(s):
    x = len(s)
    masks = [1 << i for i in range(x)]
    for i in range(1 << x):
        yield [ss for mask, ss in zip(masks, s) if i & mask]

Evens = set()
A = {1,2,3,4,5}
B = {5,6,7,3,2}
C = {5,6,7,3,2}
D = {1,2,3}
addToSetEvens(Evens, 3)
addToSetEvens(Evens, 8)
addToSetEvens(Evens, 10)
addToSetEvens(Evens, 2)
addToSetEvens(Evens, 6)

print("Evens added : {}".format(Evens))

cartesianProduct(A,Evens)

#print( "A = B : {} ".format(equalSets(A,B)) ) #this function is the same as the boolean comparison in python
print( "A = B : {} ".format( A == B ))
print( "A is Subset of B : {} ".format(subsetOfSet(C,B)) )

print(list(PowerSet([4, 5, 6])))