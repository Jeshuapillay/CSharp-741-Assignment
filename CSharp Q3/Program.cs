using System;
class Program{

    static void reverse(double []arr, int size){

        // double temp;

        // while (start < end){
        //     temp = arr[start];
        //     arr[start] = arr[end];
        //     arr[end] = temp;
        //     start++;
        //     end--;
        // }

        double temp;
        double[] temp_array = arr;

        for (int i = 0; i < (int)size/2; i++) {
            temp = temp_array[i];
            temp_array[i] = temp_array[size - (i+1)];
            temp_array[size - (i+1)] = temp;
        }

        arr = temp_array;

        
    }

    static void printArray(double []arr){
        foreach (var i in arr)
        {
            Console.Write(i + ", ");
        }
    }
    public static void Main(string[] args){
        double []my_array = {1.2, 5.5, 93.9, 2.6, 3.5};
        Console.WriteLine("Before:");
        printArray(my_array);

        Console.WriteLine("\n\nAfter:");
        reverse(my_array, my_array.Length);
        printArray(my_array);
    }

}