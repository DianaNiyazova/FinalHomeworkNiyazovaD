﻿//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа.

string[] a = { "OMG", "what", "a", "heck", "is", "going", "on" };
List<string> b = new List<string>();

for (int i = 0; i < a.Length; i++)
    if (a[i].Length <= 3)
    {
        b.Add(a[i]);
    }

Console.WriteLine("[{0}]", string.Join(",", b));