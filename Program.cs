using System;

namespace WosPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Doo do doo doo");
            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("############");



            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ring ring ringgg");
            s8.DisplayInfo();
            System.Console.WriteLine(elevenHundred.Ring());
            System.Console.WriteLine(elevenHundred.Unlock());
            System.Console.WriteLine("############");

        }
    }
}
