// See https://aka.ms/new-console-template for more information
namespace TP_MOD_6_1302210106
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vid1= new SayaTubeVideo("Tutorial Design By Contract - Stevent Rangga Ramaditya");
            vid1.IncreasePlayCount(200);
            vid1.PrintVideoDetails();

            Console.WriteLine("\n");
            SayaTubeVideo vid2 = new SayaTubeVideo("Belajar Bahasa C#");

            vid2.IncreasePlayCount(1000000000);
            vid2.PrintVideoDetails();
        }
    }
}
