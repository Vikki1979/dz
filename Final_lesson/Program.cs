Console.WriteLine("введите количество элементов массива");
int.TryParse(Console.ReadLine(), out int a);
while (a <= 0) {
    Console.WriteLine("введено некорректное число,введите правильное");
    int.TryParse(Console.ReadLine(), out a);
}

string[] InputArray(int a){
    string[] massiv = new string[a];
    for (int i = 0; i < a; i++){
        Console.WriteLine($"введите элемент массива № {i+1}");
        massiv[i] = Console.ReadLine()!;
        }
    return massiv;
}

int FindInputArrayLength(string[] massiv){
    int count = 0;
    for (int i = 0; i < a; i++){
        if (massiv[i].Length <= 3){
            count++;
        }
        }
    return count;
}

string[] NewMassiv(string[] massiv, int count){
    string[] massive_3_el = new string[count];
    int j = 0;
    for (int i = 0; i < a; i++){
        if (massiv[i].Length <= 3){
            massive_3_el[j] = massiv[i];
            j++;
        }
    }
    return massive_3_el;
}

void PrintArray(string[] array){
    if (array.Length > 0){
        Console.Write($"[{array[0]}");
        for (int i = 1; i < array.Length; i++){
            Console.Write($", {array[i]}");
    }
        Console.Write("]");
    }
    else
        Console.WriteLine("массив не содержит данных");
    Console.WriteLine();           
    }


string[] massiv = InputArray(a);
int count = FindInputArrayLength(massiv);
string[] massive_3_el = NewMassiv(massiv, count);
Console.WriteLine("массив пользователя:");
PrintArray(massiv);
Console.WriteLine("получившийся массив:");
PrintArray(massive_3_el);



