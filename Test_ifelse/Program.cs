using System;

public class Program
{
    public static void Main()
    {
        int age = 25;
        if (age < 13)
        {
            Console.WriteLine("เด็ก");
        }
        else if (age < 20)
        {
            Console.WriteLine("วัยรุ่น");
        }
        else if (age < 60)
        {
            Console.WriteLine("ผู้ใหญ่");
        }
        else
        {
            Console.WriteLine("ผู้สูงอายุ");

        }
    }
}
