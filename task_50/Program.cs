Console.Clear();
Console.Write("seminar_7 task_50\n\n");

void print2Darray(ref double[,] array){
    for (int row = 0; row < array.GetLength(0); row++){
        Console.Write("[");
        for (int col = 0; col < array.GetLength(1); col++){
                Console.Write($"{array[row, col]}\t");
        }
        Console.Write("\b\b\b\b]\n");
    }
    Console.Write("\n");
}

double[,] random2Darray(int rows=4, int cols=4, int min=0, int max=10, int afterDot=2){
    double[,] array2D = new double [rows, cols];
    for (int row = 0; row < array2D.GetLength(0); row++){
        for (int col = 0; col < array2D.GetLength(1); col++){
            array2D[row, col] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), afterDot);
        }
    }
    return array2D;
}

double[,] arr = random2Darray();
Console.Write("задан двумерный массив:\n");
print2Darray(ref arr);
Console.Write("задайте позицию: ");
int [] rows_cols = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
if (rows_cols[0] == 0 || rows_cols[1] == 0){
    Console.Write("адрес позиции должен быть больше нуля");
}
else if (rows_cols[0] - 1 < arr.GetLength(0) && rows_cols[1] - 1 < arr.GetLength(1)){
    Console.Write($"на данной позиции находится элемент {arr[rows_cols[0] - 1, rows_cols[1] - 1]}");
}
else {
    Console.Write("такой позиции в массиве нет");
}