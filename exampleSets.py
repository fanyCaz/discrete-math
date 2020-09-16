U = 191
F = 65
N = 76
M = 63
sets = []
print("Of the group of 191")
print("Will you add a set? y/n")
ans = input()
while(ans == 'y'):
    print("Insert number of students, then after commas, the subject they're into : students,F,N,M")
    x = input()
    x = x.split(',',1)
    sets.append([x[1],int(x[0])])
    print("Will you add a set? y/n")
    ans = input()

FrenchSets = [i[1] for i in sets if 'F' in i[0]]
MusicSets = [i[1] for i in sets if 'M' in i[0]]
BusinessSets = [i[1] for i in sets if 'N' in i[0]]
onlyFrench = F - sum(FrenchSets)
print("People who only take French {}".format(onlyFrench))
print(FrenchSets)