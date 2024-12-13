using System.Globalization;

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

        //Вторая задача

        double At = inputDouble("Введите массовую долю теста в готовой продукции, %: ");
        double Ptlt = (At * Ptln) / 100;
        double Ptm = inputDouble("Введите производительность тестомесильной машины, т/ч: ");
        int n2 = (int)Math.Ceiling(Ptlt / Ptm);
        Console.WriteLine("Необходимое количество тестомесильных машин: " + n1);
        Console.ReadLine();
        Console.Clear();

        //Третья задача

        double Pk = inputDouble("Введите производительность куттера, т/ч: ");
        double Ptlf = ((100 - At) * Ptln) / 100;
        int n3 = (int)Math.Ceiling(Ptlf / Pk);
        Console.WriteLine("Необходимое количество куттеров: " + n3);
        Console.ReadLine();
        Console.Clear();

        return 0;
    }


    private static double inputDouble(string str)
    {
        double value = -1;
        bool isCorrect = false;
        while (!isCorrect)
        {
            Console.Write(str);
            bool isDouble = double.TryParse(Console.ReadLine(), out value);
            isCorrect = Double.IsPositive(value) && isDouble;
        }
        return value;
    }

}