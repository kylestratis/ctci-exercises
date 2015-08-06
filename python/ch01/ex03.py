# Chapter 01
# Exercise 03
# Given 2 strings, write a method to determine
# if one is a permutation of the other.
# Some considerations to make: does case matter? Does whitespace matter?

def main():
    test_string_a = "This"
    test_string_b = "Hits"
    test_string_c = "That"
    test_string_d = "What"
    test_string_e = "This is her"
    test_string_f = "Sit her his"
    print permutation(test_string_a, test_string_b)
    print permutation(test_string_c, test_string_d)
    print permutation(test_string_e, test_string_f)

def permutation(string1, string2):
    if len(string1) != len(string2):
        return False
    list1 = list(string1.lower())
    ref_list = list(string1.lower())
    list2 = list(string2.lower())
    for char in ref_list:
        if char in list2:
            list1.remove(char)
            list2.remove(char)
        else: 
            return False
    if len(list1) != len(list2):
        return False
    else: 
        return True

if __name__ == "__main__":
    main()