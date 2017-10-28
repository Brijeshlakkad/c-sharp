﻿using System;
using System.IO;

namespace FileIOApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            FileStream F = new FileStream("xyz.txt", FileMode.OpenOrCreate,
               FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.Write((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}