# Chapter 01
# Exercise 04
# Write a method to replace all spaces in a string with '%20'
# Pretty basic for Python

def main():
    test_string = "This is a test string"
    print spaces(test_string)

def spaces_easy(input):
    return input.replace(' ','%20')

if __name__ == "__main__":
    main()