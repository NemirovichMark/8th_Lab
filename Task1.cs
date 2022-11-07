using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        //Ё = 1025
        //ё = 1105
        //а = 1072
        //я = 1103
        //А  = 1040
        //Я = 1071
        string text;
        double k = 0;
        double z = 0;
        bool t = false;
        int[] mas = new int[1200];
        Console.WriteLine("Enter the text:");
        text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            t = false;
            if (text[i] == 1025 || text[i] == 1105 || (text[i] >= 1040 && text[i] <= 1103)) { k++; t = true; mas[text[i]]++;  }
            if (t == false) z++;
        }

        double b = k / (text.Length - z) * 100;
        Console.WriteLine("Count of russian letters: " + k);
        Console.WriteLine("Frequency of russian letters: " + b + "%.");
        Console.WriteLine("Statistic of letter:");
        for (int i=0; i<1200; i++)
        {
            b = k / (text.Length - z) * 100;
            if (mas[i] > 0)
            {
                b = mas[i] / (text.Length - z) * 100;
                Console.WriteLine(Convert.ToChar(i) + " - " + b + "%");
            }
        }
        return 0;
    }
}
