using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagramsCode
{
    public class Movie
    {
        private int movieId;
        private string title;
        private string genre;
        private int releaseYear;
        private double price;
        private int stockQuantity;
        private bool availability;

        public Movie(int movieId, string title, string genre, int releaseYear, double price, bool availability)
        {
            this.movieId = movieId;
            this.title = title;
            this.genre = genre;
            this.releaseYear = releaseYear;
            this.price = price;
            this.stockQuantity = 0;
            this.availability = availability;
        }

        public void ApplyDiscount(double discountPercentage)
        {
            // Apply discount to the price
            price = price * (1 - discountPercentage);
        }

        public void UpdateStock(int newAvailability)
        {
            // Update availability status
            stockQuantity += newAvailability;
        }

        public bool IsInStock()
        {
            if (stockQuantity > 0)
            {
                availability = true;
            }
            else
            {
                availability = false;
            }
            return availability;
        }

        public int MovieId { get => movieId; set => movieId = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public double Price { get => price; set => price = value; }
        public int StockQuantity { get => stockQuantity; set => stockQuantity = value; }
        public bool Availability { get => availability; set => availability = value; }
    }
}
