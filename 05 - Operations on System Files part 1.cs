using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Operations-on-System-Files-5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            //int[] liczby = new int[10] { 9, 1, 3, 2, 7, 8, 10, 6, 5, 4 };
            List<int> dane = new List<int>();
            int[] liczby;

            // DEBUG - array listing
            //for(int i = 0; i < liczby.Length; i++)
            //{
            //    Console.Write(liczby[i] + " ");
            //}

            //Console.WriteLine();

            // DEBUG - array listing
            //for (int i = 0; i < liczby.Length; i++)
            //{
            //    Console.Write(liczby[i] + " ");
            //}

            //Console.WriteLine();

            Console.Write("Podaj nazwę katalogu, który chcesz utworzyć: ");
            string directoryName = Console.ReadLine();
            try
            {
                DirectoryInfo di = new DirectoryInfo(directoryName);
                di.Create();
                Console.WriteLine("Pomyślnie utworzono katalog " + directoryName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Podaj nazwę pliku: ");
            string fileName = Console.ReadLine();
            try
            {
                FileInfo fi = new FileInfo(directoryName + "\\" + fileName);
                fi.Create();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            using (var sw = new StreamReader(directoryName + "\\" + fileName))
            {
                try
                {
                    string line;
                    do
                    {
                        line = sw.ReadLine();
                        dane.Add(int.Parse(line));
                    } while (line != null);
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                } finally
                {
                    sw.Dispose();
                }
            }

            int tmp;
            liczby = dane.ToArray();

            for (int i = 0; i < liczby.Length; i++)
            {
                for (int j = 0; j < liczby.Length; j++)
                {
                    if (liczby[i] < liczby[j])
                    {
                        tmp = liczby[i];
                        liczby[i] = liczby[j];
                        liczby[j] = tmp;
                    }
                }
            }

            using (var sw = new StreamWriter(directoryName + "\\" + fileName))
            {
                try
                {
                    for(int i = 0; i < liczby.Length; i++)
                    {
                        sw.WriteLine(liczby[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } finally
                {
                    sw.Dispose();
                }
            }

            // Exercise 2
            Console.Write("Podaj nazwę katalogu lub pliku do usunięcia: ");
            string objToDelete = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Czy na pewno chcesz wykonać tą operację? [T/N]: ");
            ConsoleKeyInfo confirmation = Console.ReadKey();
            if (confirmation.KeyChar == 'T' || confirmation.KeyChar == 't')
            {
                try
                {
                    // Check whether objToDelete is file or directory and take actions accordingly
                    FileAttributes fa = File.GetAttributes(objToDelete);
                    if (fa.HasFlag(FileAttributes.Directory))
                    {
                        DirectoryInfo di = new DirectoryInfo(objToDelete);
                        di.Delete();
                        Console.Write("Katalog " + objToDelete + " pomyślnie usunięty");
                    }
                    else
                    {
                        FileInfo fi = new FileInfo(objToDelete);
                        fi.Delete();
                        Console.Write("Plik " + objToDelete + " pomyślnie usunięty");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (confirmation.KeyChar == 'N' || confirmation.KeyChar == 'n')
            {
                Console.WriteLine("Operacja przerwana");
            }

            // Exercise 3
            Console.Write("Podaj nazwę katalogu: ");
            string targetDir = Console.ReadLine();

            try
            {
                DirectoryInfo di = new DirectoryInfo(targetDir);
                var files = di.GetFiles();
                long sizeInTotal = 0;
                foreach(FileInfo file in files)
                {
                    // get size in bytes of file from files array
                    sizeInTotal += file.Length;
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
