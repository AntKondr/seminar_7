Console.Clear();
Console.Write("seminar_7 task_47\n\n");

void print2Darray(ref double[,] array){
    for (int row = 0; row < array.GetLength(0); row++){
        Console.Write("[");
        for (int col = 0; col < array.GetLength(1); col++){
            if (array[row, col] > 0){
                Console.Write($" {array[row, col]}\t");
            }
            else {
                Console.Write($"{array[row, col]}\t");
            }
        }
        Console.Write("\b\b\b]\n");
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

Console.Write("input rows & cols amt through space:\n");
int [] rows_cols = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] arr = random2Darray(rows: rows_cols[0], cols: rows_cols[1], min: -10);
print2Darray(ref arr);