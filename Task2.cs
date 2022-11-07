using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;

class HelloWorld
{
    static bool bukavabool(char a)
    {
        bool f;
        f = (a == 1025 || a == 1105 || (a >= 1040 && a <= 1103) || (a >= 97 && a <= 122) || (a >= 65 && a <= 90));
        return f;
    }
    static int Main()
    {
        string text;
        string a;
        int k = -1, v = -1;
        text = Console.ReadLine();
        char[] chars = new char[text.Length + 2];
        chars[0] = '1';
        chars[chars.Length - 1] = '1';
        for (int i = 0; i < text.Length; i++)
        {
            chars[i + 1] = text[i];
        }
        for (int i = 0; i < chars.Length - 1; i++)
        {
            bool q = bukavabool(chars[i]);
            bool p = bukavabool(chars[i + 1]);
            if (q == false && p == true) { k = i + 1; }
            if (q == true && p == false) { v = i; }
            if (k > -1 && v > -1)
            {
                List<char> g = new List<char>();
                for (int j = k; j <= v; j++)
                {
                    g.Add(chars[j]);
                }
                g.Reverse();
                int w = 0;
                for (int j = k; j <= v; j++)
                {
                    chars[j] = g[w];
                    w++;
                }
                k = -1;
                v = -1;
            }
        }
        for (int i = 1; i < chars.Length - 1; i++)
        {
            Console.Write(chars[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < chars.Length - 1; i++)
        {
            bool q = bukavabool(chars[i]);
            bool p = bukavabool(chars[i + 1]);
            if (q == false && p == true) { k = i + 1; }
            if (q == true && p == false) { v = i; }
            if (k > -1 && v > -1)
            {
                List<char> g = new List<char>();
                for (int j = k; j <= v; j++)
                {
                    g.Add(chars[j]);
                }
                g.Reverse();
                int w = 0;
                for (int j = k; j <= v; j++)
                {
                    chars[j] = g[w];
                    w++;
                }
                k = -1;
                v = -1;
            }
        }
        for (int i = 1; i < chars.Length - 1; i++)
        {
            Console.Write(chars[i]);
        }
        return 0;
    }
}
