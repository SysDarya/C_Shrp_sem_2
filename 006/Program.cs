// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
Console.Write ("Введите число для проверки: ");
int a = Convert.ToInt32 (Console.ReadLine());

void FillArray (int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,1000);
        index++;
    }
}

void PrintArray (int[] collection){
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (collection[position]);
        position++;
    }
}

void CheckArray (int[] collection){
    int l = collection.Length;
    int p = 0;
    while (p < l){
        int dif = collection[p] % a;
        if (dif == 0){
            Console.WriteLine ($"Число {collection[p]} кратно {a}.");
            break;
        }
        p++;
    
    }
}



int [] array = new int [3];
FillArray(array);
PrintArray(array);
CheckArray(array);