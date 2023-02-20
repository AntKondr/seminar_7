Console.Clear();
Console.Write("seminar_7 task_add_2\n\n");

void print2Darray(ref char[,] array){
    for (int row = 0; row < array.GetLength(0); row++){
        for (int col = 0; col < array.GetLength(1); col++){
                Console.Write($"{array[row, col]} ");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}

char[,] random2Darray(int rows=4, int cols=4){
    char[] pixels = {'W', 'B'};
    char[,] array2D = new char[rows, cols];
    for (int row = 0; row < array2D.GetLength(0); row++){
        for (int col = 0; col < array2D.GetLength(1); col++){
            array2D[row, col] = pixels[new Random().Next(0, 2)];
        }
    }
    return array2D;
}

Console.Write("введите высоту и ширину изображения через пробел:\n");
int [] rows_cols = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

char[,] image = random2Darray(rows: rows_cols[0], cols: rows_cols[1]);
Console.Write("\nвот Мишино исходное изображение:\n");
print2Darray(ref image);

char[,] neg_image = random2Darray(rows: rows_cols[0], cols: rows_cols[1]);
Console.Write("а вот изображение пропущенное через кривую программу Миши:\n");
print2Darray(ref neg_image);

int err_amt = 0;
for (int row = 0; row < image.GetLength(0); row++){
    for (int col = 0; col < image.GetLength(1); col++){
        if (image[row, col] == neg_image[row, col]){
            err_amt += 1;
        }
    }
}
Console.Write($"число неправильных пикселей {err_amt}");