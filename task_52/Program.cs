Console.Clear();
Console.Write("seminar_7 task_52\n\n");

void print2Darray(ref int[,] array){
    for (int row = 0; row < array.GetLength(0); row++){
        Console.Write("[");
        for (int col = 0; col < array.GetLength(1); col++){
                Console.Write($"{array[row, col]} ");
        }
        Console.Write("\b]\n");
    }
    Console.Write("\n");
}

int[,] random2Darray(int rows=4, int cols=4, int min=0, int max=10){
    int[,] array2D = new int[rows, cols];
    for (int row = 0; row < array2D.GetLength(0); row++){
        for (int col = 0; col < array2D.GetLength(1); col++){
            array2D[row, col] = new Random().Next(min, max);
        }
    }
    return array2D;
}

int[,] arr = random2Darray();
print2Darray(ref arr);
for (int col = 0; col < arr.GetLength(1); col++){
    double summa = 0;
    for (int row = 0; row < arr.GetLength(0); row++){
        summa += arr[row, col];
    }
    double average = summa / arr.GetLength(0);
    Console.Write($"average {col+1}ого столбца = {average}\n");
}