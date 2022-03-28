using System;

namespace Encapsulation
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Singer singer = new Singer();
            singer.Name = "hozier";
            Console.WriteLine(singer.Age = 190);
            Song song = new Song();
            song.AddRating(3.4);
            Console.WriteLine(song.Rating);
            song.AddRating(5);
            song.GetAverageRating();
        }
    }
}
