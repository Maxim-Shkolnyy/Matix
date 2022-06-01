namespace ShowCase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;




public class ProgramManager
{

    //ICommunication -> интерфейс для врапинга косоли, REad/Write....
    //ConsoleComunication -> имплементация интерфейса
    //запрос ввода, валидация, отправку на вывод, и т.д.Предложение пойти на повторный круг.

    //public interface IConsoleIO
    //{
    //    void WriteLine(string s);
    //    string ReadLine();
    //}

    //public void WriteLine(string s)
    //{
    //    Console.WriteLine(s);
    //}

    //public string ReadLine()
    //{
    //    return Console.ReadLine();
    //}

    //    private readonly IConsoleIO ConsoleIO;

    //    public ProgramManager(IConsoleIO consoleIO)
    //    {
    //        ConsoleIO = consoleIO;
    //    }

    //    public void Greet()
    //    {
    //        ConsoleIO.WriteLine("What's your name?");
    //        var name = ConsoleIO.ReadLine();
    //        ConsoleIO.WriteLine($"Hello {name}");
    //    }

    public void UserInput()
    {

        Console.WriteLine("Enter the number of columns");
        int rows = 0;
        while (rows == 0)
        {
            try
            {
                rows = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You enter not a number. Please, enter a number");
            }
        }

        Console.WriteLine("Enter the number of rows ");

        int columns = 0;
        while (columns == 0)
        {
            try
            {
                columns = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You enter not a number. Please, enter a number");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Matrix: ");
        Console.WriteLine();

        int[,] randomArr = new int[columns, rows];

        Random random = new Random();

        for (int i = 0; i < randomArr.GetLength(0); i++)
        {
            for (int j = 0; j < randomArr.GetLength(1); j++)
            {
                randomArr[i, j] = random.Next(100);
                Console.Write(randomArr[i, j] + "\t");
            }

            Console.WriteLine();
        }

        int diagonalSum = 0;

        for (int i = 0; i < randomArr.GetLength(0); i++)
        {
            diagonalSum += randomArr[i, i];
        }
        Console.WriteLine($"Diagonal sum: {diagonalSum}");
        Console.ReadLine();
    }

    public void UserOutput()
    {
        Console.WriteLine("Diagonal sum: ");
    }
}