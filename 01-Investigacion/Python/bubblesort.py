from time import time

class BubbleSort:
    @staticmethod
    def sort(array):
        start_time = time()

        len_arr = len(array) # Guardo la longitud del array
        for i in range(len_arr): # Primer loop que recorre todo el array
            for j in range(0, len_arr - i - 1): # Segundo loop comparando los elementos adyacentes entre si
                if array[j] > array[j + 1]: # Cambiar > a < para hacer orden descendente
                    array[j], array[j+1] = array[j+1], array[j] # Hace un cambio entre los elementos del array

        end_time = time()
        return end_time - start_time
