/* Выберите любую папку на своем компьютере, имеющую вложенные 
 * директории. Выведите на консоль ее содержимое и содержимое 
 * всех подкаталогов. */

namespace Task8
{
    class Task1
    {
        static void Main(string[] args)
        {
            string path = @"D:\\Новая папка";

            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}