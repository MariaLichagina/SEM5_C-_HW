// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArr() {
    int size = 8;
    int[] array = new int[size];
    Random randNum = new Random();

    for (int i = 0; i < size; i++){
        array[i] = randNum.Next(100, 1000);
    }
    return array;
}

int PosNum(int[] array) {
    
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count += 1;
        }
    }
    return count;
}

int [] array = GetArr();
Console.WriteLine($"[{String.Join(", ", array)}] -> {PosNum(array)}");
