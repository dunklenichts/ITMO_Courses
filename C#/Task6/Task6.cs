/* Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
 * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры 
 * матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой 
 * в каждой строке, в каждом столбце и по каждой диагонали одинакова. */

class Task6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] rowArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            int sum = 0;

            for (int j = 0; j < n; j++)
            {
                sum += array[i, j];
            }
            rowArray[i] = sum;
        }
        int tempRowSum = 0;
        for (int i = 0; i < n; i++)
        {
            tempRowSum += rowArray[i];
        }
       

        
        int[] colArray = new int[n];
        for (int j = 0; j < n; j++)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += array[i, j];
            }
            colArray[j] = sum;
        }
        int tempColSum = 0;
        for (int i = 0; i < n; i++)
        {
            tempColSum += colArray[i];
        }


        int diagArray = 0;
        for (int i = 0; i < n; i++)
        {
            diagArray += array[i, i];
        }


        int secDiagArray = 0;
        for (int i = 0; i < n; i++)
        {
            secDiagArray += array[i, n - i - 1];
        }

        for (int i = 0; i < n; i++)
        {
            if (diagArray != secDiagArray) 
            {
                Console.WriteLine("not magic");
                break;
            }
            if (tempRowSum != tempColSum)
            {
                Console.WriteLine("not magic");
                break;
            }
            if ((tempRowSum/n != secDiagArray) || (tempColSum/n != secDiagArray))
            {
                Console.WriteLine("not magic");
                break;
            }
            else
            {
                Console.WriteLine("magic");
                break;
            }
        } 

    }
}