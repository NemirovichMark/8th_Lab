using System;

namespace Task
{
    class Program
    {
        static string[] Split(string s, string separete)
        {
            Dictionary<char, int> sep = new Dictionary<char, int>();
            foreach(char c in separete)
            {
                sep[c] = 1;
            }
            List<string> list = new List<string>();
            string str = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (sep.ContainsKey(s[i]))
                {
                    if (str != "")
                    {
                        list.Add(str);
                        str = "";
                    }
                    list.Add("" + s[i]);
                }
                else
                {
                    str += s[i];
                }
            }
            if (str != "")
            {
                list.Add(str);
                str = "";
            }
            string[] S =new string[list.Count];
            for (int i = 0; i < S.Length; i++)
            {
                S[i] = list[i];
            }
            return S;
        }
        static void exercise_3_1()
        {
            Console.WriteLine("введите текс");
            string s;
            s = Console.ReadLine();
            double kolRu = 0, kolEn = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(var to in s)
            {
                if ((to >= 'а' && to <= 'я') || (to >= 'А' && to <= 'Я'))
                {
                    kolRu++;
                    if (!map.ContainsKey(to))
                    {
                        map[to] = 1;
                    }
                    else
                    {
                        map[to]++;
                    }
                }
                if ((to >= 'a' && to <= 'z') || (to >= 'A' && to <= 'Z'))
                {
                    kolEn++;
                }
            }
            //Console.WriteLine($"{ (int)'а'} {(int)'я'}");
            //Console.WriteLine($" {kolEn} {kolRu}");
            if (kolRu + kolEn == 0)
            {
                return;
            }

            for (int i = 'А'; i <= 'я'; ++i)
            { 
                double prosent = 0;
                double kol = 0;
                if (!map.ContainsKey((char)i))
                {
                    continue;
                }
                kol = map[(char)i];
                prosent = kol / (kolEn + kolRu);
                prosent *= 100;
                Console.WriteLine($"{(char)i} {prosent}%");
            }
        }

        static string Reverse(string s)
        {
            string S = "";
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                S += s[i];
            }
            return S;
        }
        static void exercise_3_2()
        {
            Console.WriteLine("введите текс");
            string s;
            s = Console.ReadLine();
            char ch = '"';
            string[] S = Split(s, " .,/;'[]{}?!" + ch);
            s = "";
            for(int i = 0; i < S.Length; i++)
            {
                s += Reverse(S[i]);
                s += "";
            }
            Console.WriteLine(s);

            s = "";
            for (int i = 0; i < S.Length; i++)
            {
                s += S[i];
                s += "";
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            #region exercise_3_1;
            exercise_3_1();
            #endregion

            #region exercise_3_2;
            exercise_3_2();
            #endregion
        }

        static string ListToString(List<double> L)
        {
            string s = "";
            foreach (double v in L)
            {
                s += v.ToString();
                s += " ";
            }
            return s;
        }
        static string ArrayToString(double[] L)
        {
            string s = "";
            foreach (double v in L)
            {
                s += v.ToString();
                s += " ";
            }
            return s;
        }
        static string[] ArrayToString(double[][] L, int n = 0)
        {
            string[] S = new string[n];
            int sh = 0;
            foreach (double[] v in L)
            {
                S[sh] = ArrayToString(v);
                sh++;
            }
            return S;
        }
        static string[] ArrayToString(double[,] L)
        {
            int n = L.GetLength(0), m = L.GetLength(1);
            string[] S = new string[n];
            for (int i = 0; i < n; i++)
            {
                string s = "";
                for (int j = 0; j < m; j++)
                {
                    s += L[i, j].ToString();
                    s += " ";
                }
                S[i] = s;
            }
            return S;
        }
        static int Compare((double, int) x, (double, int) y)
        {
            if (x.Item1 < y.Item1)
            {
                return 1;
            }

            if (x.Item1 > y.Item1)
            {
                return -1;
            }

            return 0;
        }
    }

    static class InputOutput
    {
        public const string EndString = "";
        static public void Write(int ans)
        {
            Console.WriteLine("ans : " + ans.ToString());
        }
        static public void Write(double ans)
        {
            Console.WriteLine("ans : " + ans.ToString());
        }
        static public bool Read(out string s)
        {
            s = Console.ReadLine();
            if (s == EndString)
            {
                return false;
            }
            return true;
        }
        static public bool Read(out double x)
        {
            string s;
            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x)
        {
            string s;
            s = Console.ReadLine();

            if (!int.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!int.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }
        static public bool Read(out double x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!double.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }

        static public bool CheckRead(out double x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static public bool CheckRead(out int x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static public bool CheckSplitRead(out List<double> L, out bool Check, string Erorr = "ошибка", int? kol = null, string? ans = null)
        {
            Check = false;
            List<double> l = new List<double>();
            L = l;
            string? s = Console.ReadLine();
            if (s == EndString)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                if (ans == null)
                {
                    Check = true;
                }
                return false;
            }
            if (s == null)
            {
                Console.WriteLine(Erorr);
                return false;
            }
            string[] S = s.Split(" ");
            foreach (string st in S)
            {
                double x;
                if (st == "") continue;
                if (!double.TryParse(st, out x))
                {
                    Console.WriteLine(Erorr);
                    return false;
                }
                L.Add(x);
            }
            if (kol != null && L.Count() != kol)
            {
                Console.WriteLine("не верное количество элементов в строке");
                return false;
            }
            return true;
        }
    }
    class Comparer : IComparer<double>
    {
        public int A = 1;
        public Comparer(int a)
        {
            A = a;
        }
        public int Compare(double p1, double p2)
        {
            if (p1 < p2)
            {
                return -1 * A;
            }
            if (p1 > p2)
            {
                return A;
            }

            return 0;
        }
    }
    class Person
    {
        public string name;
    }
    class Student : Person
    {
        public List<double> grades = new List<double>();
        public double midGrade = 0;
        //public string name;
        public Student(double[] x, string name = "неизвестно")
        {
            int dl = x.Length;
            double sum = 0;
            for (int i = 0; i < dl; i++)
            {
                grades.Add(x[i]);
                sum += x[i];
            }
            if (dl != 0)
            {
                midGrade = sum / dl;
            }
            this.name = name;
        }
        public Student(List<double> x, string name = "неизвестно")
        {
            int dl = x.Count;
            double sum = 0;
            for (int i = 0; i < dl; i++)
            {
                grades.Add(x[i]);
                sum += x[i];
            }
            if (dl != 0)
            {
                midGrade = sum / dl;
            }
            this.name = name;
        }
    }
    class Skier : Person
    {
        //public string name;
        public double rez1, rez2, sum;
        public Skier(double rez1, double rez2, string name = "неизвестно")
        {
            this.name = name;
            this.rez1 = rez1;
            this.rez2 = rez2;
            sum = rez1 + rez2;
        }
    }
    class Group
    {
        public string name = "неизвестно";
        public List<Student> students = new List<Student>();
        public Group(string name = "неизвестно")
        {
            this.name = name;
        }
        public double MidGrade()
        {
            double sum = 0, ans = 0;
            foreach (Student student in students)
            {
                sum += student.midGrade;
            }

            if (students.Count != 0)
            {
                ans = sum / students.Count;
            }
            return ans;
        }

    }
}