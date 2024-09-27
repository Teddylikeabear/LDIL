namespace Assignment1
{
    public class BeerSong
    {
        public void SingSong()
        {
            int bottles = 99;

            do
            {
                if (bottles > 1)
                {
                    Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {bottles - 1} bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                }

                Console.WriteLine();
                bottles--;

            } while (bottles > 0);

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
           
        }
    }

    class Program
    {
        static void Main()
        {
            BeerSong song = new BeerSong();
            song.SingSong();
        }
    }


}
