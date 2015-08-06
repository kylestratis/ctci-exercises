# Chapter 01
# Exercise 05
# Perform basic string compression, e.g. 'aaabbcccc' => 'a3b2c4'
# If string can't be compressed further, return original string

def main():
    compressed = "aabc"
    uncompressed = "abbbcccccdd"
    print(compress(compressed))
    print(compress(uncompressed))

def compress(msg):
    unique = unique_chars(msg)
    u_count = len(unique)
    new_string = ""
    if u_count * 2 >= len(msg):
        return msg
    for char in msg:
        if char not in new_string:
            new_string += char + str(unique[char])
    return new_string

def unique_chars(input_string):
    unique = dict()
    for char in input_string:
        if char not in unique:
            unique[char] = 1
        else:
            unique[char] += 1
    return unique

if __name__ == "__main__":
    main()