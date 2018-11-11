using System;

namespace homework_1CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] table = new string[3][];
            Boolean main =false, sub = false,down = false,up = false;

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new string[table.Length];
                for (int j = 0; j < table[i].Length; j++)
                {
                    if (j == i)
                    {
                        if (!main)
                        {
                            table[i][j] = "main";
                            main = true;
                        }
                        else
                        {
                            table[i][j] = "center";
                            main = false;
                        }
                    }
                   if (i > j)
                    {
                        if (!down)
                        {
                            table[i][j] = "down";
                            down = true;
                        }
                        else
                        {
                            down = false;
                        }
                    }
                   if (i < j)
                    {
                        if (!up)
                        {
                            table[i][j] = "up";
                            up = true;
                        }
                        else
                        {
                            up = false;
                        }
                    }
                   if (i + j == table.Length - 1)
                    {
                        if (!sub)
                        {
                            table[i][j] = "sub";
                            sub = true;
                        }
                        else
                        {
                            sub = false ;
                        }
                    }
                }
            }
            for (int row = 0; row < table.Length; row++)
            {
                for (int col = 0; col < table[row].Length; col++)
                {
                    Console.Write(table[row][col] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}