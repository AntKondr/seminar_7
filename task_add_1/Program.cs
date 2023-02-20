Console.Clear();
Console.Write("seminar_7 task_add_1\n\n");

void print2Darray(ref int[,] arr){
    for (int row = 0; row < arr.GetLength(0); row++){
        Console.Write("[");
        for (int col = 0; col < arr.GetLength(1); col++){
                Console.Write($"{arr[row, col]} ");
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

void transp(ref int[,] arr){
    int last_row = arr.GetLength(0) - 1;
    for (int row = 0; row < arr.GetLength(0) / 2; row++){
        for (int col = 0; col < arr.GetLength(1); col++){
            int temp = arr[row, col];
            arr[row, col] = arr[last_row, col];
            arr[last_row, col] = temp;
        }
        last_row -= 1;
    }
}


Console.Write("input rows & cols amt through space:\n");
int [] rows_cols = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] arr = random2Darray(rows_cols[0], rows_cols[1]);
Console.Write("исходная матрица:\n");
print2Darray(ref arr);
transp(ref arr);
Console.Write("матрица после транспонирования:\n");
print2Darray(ref arr);