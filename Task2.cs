using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        string text;
        Console.WriteLine("Enter the text:");
        text = Console.ReadLine();
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine("Encrypted string: ");
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(chars[i]);
        }
        Array.Reverse(chars);
        Console.WriteLine();
        Console.WriteLine("Decrypted string: ");
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(chars[i]);
        }
        return 0;
    }
}
