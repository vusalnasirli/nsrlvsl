using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Song
    {
        private string _name;
        private string _genre;
        private double _rating=0;
        private int _ratingCount;
        private Singer _singer;
        public Singer Singer { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value == "Pop" || value == "Rock" || value=="Jazz"|| value=="Techno")
                {
                    _genre = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                    _rating = value;
               
            }
        }
        public int RatingCount
        {
            get
            {
                return _ratingCount;
            }
            set
            {
                _ratingCount = value;

            }
        }
        public void AddRating(double rating)
        {
            RatingCount += 1;
            Rating += rating;
        }
        public void GetAverageRating()
        {
            Console.WriteLine(Rating/RatingCount);
        }
    }

}
