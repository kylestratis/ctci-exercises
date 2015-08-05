# Chapter 01
# Exercise 06
# Given an image represented by an NxN matrix, where each pixel is
# 4 bytes, rotate the image by 90 degrees. Can you do this in place
# Algorithm: reverse rows, then put first column into a row, second 
# into row, etc.

def main():
    input_matrix = [[1, 2], [1, 2]]
    input_matrix2 = [[3, 2, 7], [6, 5, 2], [8, 9, 0]]
    print(rotate(input_matrix))
    print(rotate_one_line(input_matrix))
    print(rotate(input_matrix2))    
    print(rotate_one_line(input_matrix2))

# Without slicing or any fancy python tricks
def rotate(matrix):
    reversed_matrix = []
    for row in matrix:
        reversed_matrix.append([])
    for row in reversed(matrix):
        for cell in range(len(row)):
            reversed_matrix[cell].append(row[cell])
    return reversed_matrix




def rotate_one_line(matrix):
    return zip(*matrix[::-1])

if __name__ == "__main__":
    main()