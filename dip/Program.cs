﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        struct Element
        {

            public int Delivery { get; set; }
            public int Value { get; set; }
            public static int FindMinElement(int a, int b)
            {
                if (a > b) return b;
                if (a == b) { return a; }
                else return a;
            }

        }

        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int n;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите количество A");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите количество B");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            Element[,] C = new Element[n, m];
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введите a[i]");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите b[i]");
            for (j = 0; j < b.Length; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите C[i][j]");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    Console.ForegroundColor = ConsoleColor.Red;
                    C[i, j].Value = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                }
            }
            i = j = 0;
            // действуем по алгоритму 

            // идём с северо-западного элемента 
            // если a[i] = 0 i++
            // если b[j] = 0 j++
            //  если a[i],b[j] = 0 то i++,j++;
            // доходим до последнего i , j
            while (i < n && j < m)
            {

                try
                {
                    if (a[i] == 0) { i++; }
                    if (b[j] == 0) { j++; }
                    if (a[i] == 0 && b[j] == 0) { i++; j++; }
                    C[i, j].Delivery = Element.FindMinElement(a[i], b[j]);
                    a[i] -= C[i, j].Delivery;
                    b[j] -= C[i, j].Delivery;
                }
                catch { }
            }
            //выводим массив на экран
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (C[i, j].Delivery != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", C[i, j].Value);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("({0})", C[i, j].Delivery); Console.ResetColor();
                    }
                    else
                        Console.Write("{0}({1})", C[i, j].Value, C[i, j].Delivery);
                }
                Console.WriteLine();
            }
            int ResultFunction = 0;
            //считаем целевую функцию
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++) { ResultFunction += (C[i, j].Value * C[i, j].Delivery); }
            }

            Console.WriteLine(" Result = {0}", ResultFunction);
            i = 0;
            j = 0;
            int[] u = new int[n];
            int[] v = new int[m];




            Console.ReadLine();





        }
    }
}