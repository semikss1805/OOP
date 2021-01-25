﻿using System;
using System.IO;


namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = 0;
            try
            {
                StreamWriter noFile = new StreamWriter("no_file.txt"),
                             badData = new StreamWriter("bad_data.txt"),
                             overflow = new StreamWriter("overflow.txt");
                for (int i = 10; i < 30; i++)
                {
                    int mulRes = 1;
                    try
                    {
                        using (StreamReader sr = File.OpenText(i + ".txt"))
                        {
                            mulRes *= int.Parse(sr.ReadLine());
                            mulRes *= int.Parse(sr.ReadLine());
                            try
                            {
                                int.Parse(sr.ReadLine());
                                throw new FormatException();
                            }
                            catch (ArgumentNullException)
                            {

                            }
                            catch (Exception)
                            {
                                throw new FormatException();
                            }
                        }
                        result += mulRes;
                        n++;
                    }
                    catch (FileNotFoundException)
                    {
                        noFile.WriteLine(i + ".txt");
                    }
                    catch (Exception ex) when (ex is ArgumentNullException || ex is FormatException)
                    {
                        badData.WriteLine(i + ".txt");
                    }
                    catch (OverflowException)
                    {
                        overflow.WriteLine(i + ".txt");
                    }
                }
                try
                {
                    Console.WriteLine("Average: " + (result / (double)n));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Not enough data");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't create or open file(s)");
            }
        }
    }
}
