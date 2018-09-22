using System;

class Program
{
    static void Main(string[] args)
    {
        uint inn = GetInt("Введите Ваш идентификационный код (ИНН) => ");

        int[] arr = GetArray(inn);

        int[] code = new int[] { -1, 5, 7, 9, 4, 6, 10, 5, 7 };

        int sum = 0;
        for (int i = 0; i < 9; ++i)
        {
            sum += arr[i] * code[i];
        }

        sum %= 11;

        Console.WriteLine();

        if (inn % 10 == sum)
        {
            Console.WriteLine("Введенный ИНН верный");
        }
        else
        {
            Console.WriteLine("Введенный ИНН неверный");
        }
        Console.WriteLine();

        if (arr[8] % 2 == 0)
        {
            Console.WriteLine("Ваш пол - Женщина");
        }
           

        else
        {
            Console.WriteLine("Ваш пол - Мужчина");
        }
        Console.WriteLine();

        string s = Convert.ToString (inn);
        string b = s.Substring(0, 5);

        int col = Int32.Parse(b)-1;        
        
        DateTime date = new DateTime(1900, 01, 01);
        Console.WriteLine("Вы родились - в " + date.AddDays(col).ToShortDateString());  
        

        Console.ReadKey();
        

    }

    private static int[] GetArray(uint inn)
    {
        int[] res = new int[9];
        inn /= 10;
        for (int i = 0; i < 9; ++i)
        {
            res[i] = (int)(inn % 10);
            inn /= 10;
        }
        Array.Reverse(res);
        return res;
    }

    public static uint GetInt(string quastion)
    {
        uint res;
        do
        {
            Console.Write(quastion);
        } while (!UInt32.TryParse(Console.ReadLine(), out res));
        return res;
    }

}