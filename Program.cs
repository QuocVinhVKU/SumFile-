using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập đường dẫn của file: ");
        string filePath = Console.ReadLine();

        try
        {
            int sum = CalculateSum(filePath);
            Console.WriteLine("Tổng các số trong file: " + sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }

        Console.ReadLine();
    }

    static int CalculateSum(string filePath)
    {
        int sum = 0;
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (int.TryParse(line, out int number))
            {
                sum += number;
            }
            else
            {
                throw new Exception("File chứa các giá trị không phải là số.");
            }
        }

        return sum;
    }
}
