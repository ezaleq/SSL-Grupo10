from bubblesort import BubbleSort
import random

if __name__ == "__main__":
    arr = [random.randint(1,100000) for _ in range(10000)]
    elapsed_time = BubbleSort.sort(arr)
    print(arr)
    print("Tiempo de ejecución en segundos:", elapsed_time)