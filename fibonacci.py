# Implementation of function to get the n-st number of a Fibonnaci sequence in Python 

def fibo(n):
    if n <= 1:
        return n
    else:
        return (fibo(n-1) + fibo(n-2))

if __name__ == '__main__':
    print('Fibonacci Sequence\n')

    # Print the 20 first numbers of the Fibonacci Sequence
    for x in range(21):
        print('index - {} \t value = {}'.format(x, fibo(x)))