internal class Program
{
    static void inputOneDimArray(ref double[]A)
    {
        Console.WriteLine("\tЗаполните одномерный массив: ");
        for (int i = 0; i < A.Length; i++)
            A[i] = Convert.ToDouble(Console.ReadLine());
    }
    static void randTwoDimArray(ref double[,]B)
    {
        Console.WriteLine("\tЗаполнение двумерного массива случайными числами...");
        int rows = B.GetUpperBound(0)+1;
        int colms = B.GetUpperBound (1)+1;
        Random rand = new();
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
                B[i, j] = rand.NextDouble()*100;
    }
    static void showOneDimArray(ref double[]A)
    {
        Console.WriteLine("Одномерный массив дробных чисел: ");
        foreach (var item in A)
            Console.Write(item.ToString()+" ");
        Console.WriteLine();
    }
    static void showTwoDimArray(ref double[,]B)
    {
        Console.WriteLine("Двумерный массив дробных чисел: ");
        int rows = B.GetUpperBound(0) + 1; 
        int colms = B.GetUpperBound(1) + 1; 
        int i,j;
        i = 0;
        while(i<rows)
        {
            j = 0;
            while(j<colms)
            {
                Console.Write("{0,6:F2}",B[i,j]);
                j++;
            }
            i++;
            Console.WriteLine();
        }
    }
    static double maxElem(double[] A, double[,]B)
    {
        double max = A.Max();
        int rows = B.GetUpperBound(0) + 1;
        int colms = B.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                if (B[i,j] > max)
                    max = B[i,j];
            }
        return max;
    }
    static double minElem(double[] A, double[,]B)
    {
        double min = A.Min();
        int rows = B.GetUpperBound(0) + 1;
        int colms = B.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                if (B[i, j] < min)
                    min = B[i, j];
            }
        return min;

    }
    static double proizvedenie(double[]A,double[,]B)
    {
        double proiz = 1;
        foreach (var item in A)
            proiz *= item;
        int rows = B.GetUpperBound(0) + 1;
        int colms = B.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                proiz *= B[i, j];
            }
        return proiz;
    }

    static double summa(double[] A, double[,] B)
    {
        double sum = A.Sum();
        int rows = B.GetUpperBound(0) + 1;
        int colms = B.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                sum += B[i, j];
            }
        return sum;
    }
    static double evenSum(double[]A)
    {
        double sum = 0;
        foreach (var item in A)
        {
            if(item%2==0)
                sum+= item;
        }
        return sum;
    } 
    static double unevenColumsSum(double[,]B)
    {
        double sum = 0;
        int rows = B.GetUpperBound(0) + 1;
        int colms = B.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
            for (int j = 1; j < colms; j+=2)
            {
                sum += B[i, j];
            }
        return sum;
    }
    private static void Main(string[] args)
    {
        double[] A = new double[5];
        double[,] B = new double[3, 4];
        
        inputOneDimArray(ref A);
        showOneDimArray(ref A);
        randTwoDimArray(ref B);
        showTwoDimArray(ref B);
        Console.WriteLine("\nМаксимальный элемент для двух массивов: {0,6:F2}", maxElem(A, B));
        Console.WriteLine("\nМинимальный элемент для двух массивов: {0,6:F2}", minElem(A, B));
        Console.WriteLine("\nСумма всех элементов обоих массивов: {0,6:F2}", summa(A, B));
        Console.WriteLine("\nПроизведение всех элементов обоих массивов: {0,6:F2}", proizvedenie(A, B));
        Console.WriteLine("\nСумма четных элементов одномерного массива: {0,6:F2}", evenSum(A));
        Console.WriteLine("\nСумма элементов нечетных столбцов двумерного массива: {0,6:F2}", unevenColumsSum(B));

    }
}