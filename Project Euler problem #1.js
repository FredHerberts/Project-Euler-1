var sum = 0
for (x = 3; x < 1000; x+= 3) {sum += x}
for (x = 5; x < 1000; x+= 5) {sum += x}
for (x = 15; x < 1000; x+= 15) {sum -= x}

alert(sum)
