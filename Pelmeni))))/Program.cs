public class Program()
{
    public static int Main()
    {
        //Первая задача
        
        double Ptln = inputDouble("Введите кол-во суточной выработки пельменей))), т: ") / 16;
        double Ppa = inputDouble("Введите производительность пельменного автомата, т/ч: ");
        int n1 = (int)Math.Ceiling(Ptln / Ppa);
        Console.WriteLine("Необходимое количество пельменных автоматов: " + n1);
        Console.ReadLine();
        Console.Clear();


        return 0;
    }


    private static double inputDouble(string str)
    {
        double value = -1;
        bool isDouble = false;
        while (!isDouble)
        {
            Console.Write(str);
            isDouble = double.TryParse(Console.ReadLine(), out value);
        }
        return value;
    }

}