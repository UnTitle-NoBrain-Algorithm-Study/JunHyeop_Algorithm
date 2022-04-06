string=input()
result=""

for ch in string:
    if ch.isupper():
        result+=ch.lower()
    else:
        result+=ch.upper()

print(result)