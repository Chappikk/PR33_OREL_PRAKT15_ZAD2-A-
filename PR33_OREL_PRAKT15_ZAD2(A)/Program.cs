using System;
using System.Collections;
using System.IO;

namespace PR33_OREL_PRAKT15_ZAD2_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine(" Введите вырежение = ");
            a = Console.ReadLine();
            Stack skobki = new Stack();
            bool flag = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(') skobki.Push(i);
                else if (a[i] == ')') 
                {
                   
                    if (skobki.Count == 0)
                    { flag = false; Console.WriteLine("Возможно в позиции " + i + " лишняя ) скобка"); }
                    else skobki.Pop(); 
                }
            }
            if (skobki.Count == 0) { if (flag) Console.WriteLine("скобки сбалансированы"); }
            else 
            {
                Console.Write("Возможно лишняя ( скобка в позиции: ");
                while (skobki.Count != 0)
                {
                    Console.Write("{0} ", (int)skobki.Pop());
                }
                Console.WriteLine();
            }
            StreamWriter sw = new StreamWriter("t.txt");
            sw.Write(a);
            sw.Close();
        }
    }
    
}
