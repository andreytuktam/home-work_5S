
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void newMass1(){
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    int[] newMass = new int[length];
    int P = 0;
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
        if (newMass[i] % 2 == 0)
        {
            P++;
            Console.Write($"{newMass[i]}, ");
        }
    }
    Console.WriteLine($"четных чисел в массиве newMass - {P}"); 
}
newMass1();


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
       

void newMass2(){    
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    int[] newMass = new int[length];
    int P = 0;
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
        if (i % 2 == 0)
        {
            P = newMass[i] + P;
            Console.WriteLine($"{newMass[i]} на позиции {i}");
        }
    }
    Console.WriteLine($"сумма чисел четных индексов в массиве newMass - {P}");    
}       
//newMass2();

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void newMass3(){
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    int[] newMass = new int[length];
    int Pmax = newMass[0];
    int Pmin = newMass[0];
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
    }
        for (int j = 0; j < length; j++){

            if (newMass[j] > Pmax)
            {
                Pmax = newMass[j];
            } 
            else 
            {  
                Pmin = newMass[j];
            }        
        }
Console.WriteLine($"{Pmax} - максимальное число");
Console.WriteLine($"{Pmin} - минимальное число");
}
//newMass3();


