// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] GetArr () {
int size = 7;
double [] array = new double [size];
Random RandNum = new Random();
for (int i = 0; i < size; i++){
        array[i] = Math.Round(RandNum.NextDouble(), 2);
    }
    return array;
}

double FindDiff (double [] array) {  
double min = array[0];
double max = array[0];
for(int i = 1; i < array.Length; i++){
    if (array[i] > max) {
        max  = array[i];
    } else if (array[i]<min){
        min = array[i]; 
    }
}
double diff = max - min;
return diff;
}
double [] array = GetArr();
Console.WriteLine($"[{String.Join(", ", array)}] -> {FindDiff(array)}");

