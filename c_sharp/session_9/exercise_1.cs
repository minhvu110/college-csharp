
using System;
using System.IO;


namespace Workspace
{
    class Program
    {
        static void CreateBlankFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Console.WriteLine("file created");
            }
            else
            {
                Console.WriteLine("file already exists");
            }
        }
        static void RemoveFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("file deleted");
            }
            else
            {
                Console.WriteLine("file doesnt exist");
            }
        }
        static void CreateAndWriteFile(string path, string text)
        {
            File.WriteAllText(path, text);
        }
        static string CreateAndReadFile(string path, string text)
        {
            File.WriteAllText(path, text);
            return File.ReadAllText(path);
        }
        static void WriteArrayToFile(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }
        static void AppendText(string path, string text)
        {
            File.AppendAllText(path, text + Environment.NewLine);
        }
        static string CopyFileAndDisplay(string source, string destination)
        {
            File.Copy(source, destination, true);
            return File.ReadAllText(destination);
        }
        static string CreateAndMoveFile(string path, string newName, string text)
        {
            File.WriteAllText(path, text);

            string directory = Path.GetDirectoryName(path);
            if (directory == null || directory == "")
            {
                directory = Directory.GetCurrentDirectory();
            }

            string destination = Path.Combine(directory, newName);
            File.Move(path, destination);
            return destination;
        }
        static string ReadFirstLine(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    return "";
                }
                return line;
            }
        }
        static string ReadLastLine(string path)
        {
            string[] lines = File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                return lines[lines.Length - 1];
            }
            return "";
        }
        static string CreateAndReadLastLine(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
            return ReadLastLine(path);
        }
        static string ReadLastNLines(string path, int n)
        {
            string[] lines = File.ReadAllLines(path);
            string output = "";

            int start = Math.Max(0, lines.Length - n);

            for (int i = start; i < lines.Length; i++)
            {
                output += lines[i] + Environment.NewLine;
            }
            return output;
        }
        static string ReadSpecificLine(string path, int lineNumber)
        {
            string[] lines = File.ReadAllLines(path);

            if (lineNumber >= 1 && lineNumber <= lines.Length)
            {
                return lines[lineNumber - 1];
            }
            return "line doesnt exist";
        }
        static int CountLines(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines.Length;
        }
        static void PrintFolderStructure(string path, string indent)
        {
            Console.WriteLine(indent + Path.GetFileName(path));

            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                PrintFolderStructure(directory, indent + "  ");
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine(indent + "  " + Path.GetFileName(file));
            }
        }
        static void CharacterStatistics(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }

            char[,] content = new char[lines.Length, maxLength];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    content[i, j] = lines[i][j];
                }
            }

            int[] appearances = new int[char.MaxValue + 1];
            int alphabets = 0;
            int digits = 0;
            int specialChars = 0;
            int totalChars = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    char c = content[i, j];

                    appearances[c]++;
                    totalChars++;

                    if (char.IsLetter(c))
                    {
                        alphabets++;
                    }
                    else if (char.IsNumber(c))
                    {
                        digits++;
                    }
                    else
                    {
                        specialChars++;
                    }
                }
            }

            Console.WriteLine($"Total characters: {totalChars}");
            Console.WriteLine($"Alphabets: {alphabets}");
            Console.WriteLine($"Digits: {digits}");
            Console.WriteLine($"Special Characters: {specialChars}");

            Console.WriteLine("Character appearance statistics:");

            for (int i = 0; i < appearances.Length; i++)
            {
                if (appearances[i] > 0)
                {
                    char c = (char)i;

                    if (c == ' ')
                    {
                        Console.WriteLine($"Space: {appearances[i]}");
                    }
                    else if (c == '\t')
                    {
                        Console.WriteLine($"Tab: {appearances[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"'{c}': {appearances[i]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //1.to create a blank file on the disk.
            System.Console.Write("enter file path: ");
            string blankFile = Console.ReadLine();
            CreateBlankFile(blankFile);

            //2.to remove a file from the disk.
            System.Console.Write("enter file path to remove: ");
            string removePath = Console.ReadLine();
            RemoveFile(removePath);

            //3.to create a file and add some text.
            System.Console.Write("enter file path: ");
            string writePath = Console.ReadLine();
            System.Console.Write("enter your text: ");
            string writeText = Console.ReadLine();
            CreateAndWriteFile(writePath, writeText);
            System.Console.WriteLine("text written to file");

            //4.create a text file and read it.
            System.Console.Write("enter file path: ");
            string readWritePath = Console.ReadLine();
            System.Console.Write("enter your text: ");
            string fileText = Console.ReadLine();
            System.Console.WriteLine(CreateAndReadFile(readWritePath, fileText));

            //5.to create a file and write an array of strings to the file.
            System.Console.Write("enter file path: ");
            string arrayPath = Console.ReadLine();
            System.Console.Write("enter the number of strings: ");
            int numberOfStrings = Convert.ToInt32(Console.ReadLine());

            string[] arrayOfStrings = new string[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                System.Console.Write($"enter string {i + 1}: ");
                arrayOfStrings[i] = Console.ReadLine();
            }

            WriteArrayToFile(arrayPath, arrayOfStrings);
            System.Console.WriteLine("array written to file");

            //6.to append some text to an existing file.
            System.Console.Write("enter file path: ");
            string appendPath = Console.ReadLine();
            System.Console.Write("enter text to append: ");
            string appendText = Console.ReadLine();
            AppendText(appendPath, appendText);
            System.Console.WriteLine("text appended");

            //7.to create and copy the file to another name and display the content.
            System.Console.Write("enter source file path: ");
            string sourceCopy = Console.ReadLine();
            System.Console.Write("enter destination file path: ");
            string destinationCopy = Console.ReadLine();

            System.Console.WriteLine("file content:");
            System.Console.WriteLine(CopyFileAndDisplay(sourceCopy, destinationCopy));

            //8.to create a file and move it into the same directory with another name.
            System.Console.Write("enter file path to create: ");
            string movePath = Console.ReadLine();
            System.Console.Write("enter new file name: ");
            string newName = Console.ReadLine();
            System.Console.Write("enter your text: ");
            string moveText = Console.ReadLine();

            System.Console.WriteLine($"new file path: {CreateAndMoveFile(movePath, newName, moveText)}");

            //9.read the first line of a file.
            System.Console.Write("enter file path: ");
            string firstLinePath = Console.ReadLine();
            System.Console.WriteLine($"first line: {ReadFirstLine(firstLinePath)}");

            //10.to create and read the last line of a file.
            System.Console.Write("enter file path: ");
            string lastLinePath = Console.ReadLine();
            System.Console.Write("enter the number of lines: ");
            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            string[] lines = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                System.Console.Write($"enter line {i + 1}: ");
                lines[i] = Console.ReadLine();
            }

            System.Console.WriteLine($"last line: {CreateAndReadLastLine(lastLinePath, lines)}");

            //11.create and read the last n lines of a file.
            System.Console.Write("enter file path: ");
            string lastNPath = Console.ReadLine();
            System.Console.Write("enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"last {n} lines:");
            System.Console.WriteLine(ReadLastNLines(lastNPath, n));

            //12.to read a specific line from a file.
            System.Console.Write("enter file path: ");
            string specificLinePath = Console.ReadLine();
            System.Console.Write("enter line number: ");
            int lineNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine(ReadSpecificLine(specificLinePath, lineNumber));

            //13.to count the number of lines in a file.
            System.Console.Write("enter file path: ");
            string countPath = Console.ReadLine();

            System.Console.WriteLine($"Total lines: {CountLines(countPath)}");

            //14.to print the structure of specific folder (include files).
            System.Console.Write("enter folder path: ");
            string folderPath = Console.ReadLine();

            PrintFolderStructure(folderPath, "");

            //15.read a text file, then calculate the statistics of the appearance of characters and numbers.
            System.Console.Write("enter file path: ");
            string statisticsPath = Console.ReadLine();

            CharacterStatistics(statisticsPath);

            Console.ReadKey();
        }
    }
}
