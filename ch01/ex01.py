# Chapter 01
# Exercise 01
# Implement an algorithm to determine if
# a string has all unique characters. What if
# you cannot use additional data structures?

def main():
    test_data = ["Not unique", "Uniq"]
    unique_characters(test_data[0])
    unique_characters(test_data[1])

def unique_characters(str):
    unique_chars = []
    nonunique_chars = []
    for char in str:
        if char not in unique_chars:
            unique_chars.append(char)
        else:
            nonunique_chars.append(char)
    if len(nonunique_chars) > 0:
        print "The string '%s' is NOT composed of unique characters." % str
    else:
        print "The string '%s' is composed of unique characters." % str
        

if __name__ == "__main__":
    main()