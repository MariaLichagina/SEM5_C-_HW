// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArr () {
int size = 5;
int [] array = new int [size];
Random RandNum = new Random();
 for (int i = 0; i < size; i++){
        array[i] = RandNum.Next(2, 10);
    }
    return array;
}

int FindSum (int[] array) {
    
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 == 1){
            count += array[i];
        }
    }
    return count;
}

int [] array = GetArr();
Console.WriteLine($"[{String.Join(", ", array)}] -> {FindSum(array)}");