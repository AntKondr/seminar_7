Console.Clear();
Console.Write("seminar_7 task_add_3\n\n");

void print2Darray(ref int[,] arr){
    for (int row = 0; row < arr.GetLength(0); row++){
        for (int col = 0; col < arr.GetLength(1); col++){
                Console.Write($"{arr[row, col]}\t");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}

Console.Write("введите высоту и ширину массива через пробел:\n");
int[] rows_cols = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] arr = new int[rows_cols[0], rows_cols[1]];
Console.Write("\n");

int nap = 1;
int row;
int col;
int last_row = arr.GetLength(0);
int last_col = arr.GetLength(1);
int k = 1;
int s = 1;

while (k < last_col){
    col = k;
    row = 0;
    while (row < last_row && col >= 0){
        arr[row, col] = nap;
        nap += 1;
        row += 1;
        col -= 1;
    }
    k += 1;
}

while (s < last_row){
    row = s;
    col = last_col - 1;
    while (row < last_row && col >= 0){
        arr[row, col] = nap;
        nap += 1;
        row += 1;
        col -= 1;
    }
    s += 1;
}

print2Darray(ref arr);