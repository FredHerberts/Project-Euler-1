import time
start = time.time()

multi3 = [3]
multi5 = [5]
multi5_union_multi3 = [15]

def multip3(a):
    for x in range (a,1000,3):
            multi3.append(x)

def multip5(b):
    for x in range(b,1000,5):
            multi5.append(x)

def multip5_union_multip3(c):
    for x in range(c,1000,15):
            multi5_union_multi3.append(x)

multip3(6)
multip5(10)
multip5_union_multip3(30)
end = time.time()
print(end - start)

print(sum(multi3)+sum(multi5)-sum(multi5_union_multi3 ))
