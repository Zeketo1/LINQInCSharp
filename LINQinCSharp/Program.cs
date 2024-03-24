namespace LINQinCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ in C#.......");
            /*LearningLINQ lq = new LearningLINQ();
            lq.ManipulateLINQ();*/

            Business bus = new Business();
            bus.ManipulateLINQ();

            Game game = new Game();
            game.ManipulateLINQ2();

            Music music = new Music();
            music.ManipulateLINQ3();
        }
    } 
}