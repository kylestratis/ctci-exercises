# Chapter 01
# Exercise 01
# Implement an algorithm to determine if
# a string has all unique characters. What if
# you cannot use additional data structures?

def main():
    test_data = ["Not unique", "Uniq"]
    print unique_characters(test_data[0])
    print unique_characters(test_data[1])

def unique_characters(str):
    unique_chars = set()
    for char in str:
        if char not in unique_chars:
            unique_chars.add(char)
        else:
            return False
    return True        

if __name__ == "__main__":
    main()