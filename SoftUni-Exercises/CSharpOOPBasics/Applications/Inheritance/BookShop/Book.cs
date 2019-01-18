using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title cannot be less than 3 symbols!");
                }

                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                string secondAuthorName = value.Split(' ')[1];
                bool containsDigit = false;

                foreach (var character in secondAuthorName)
                {
                    if (character >= 48 && character <= 57)
                    {
                        containsDigit = true;
                    }
                }

                if (containsDigit)
                {
                    throw new ArgumentException("Author's second name cannot contain a digit!");
                }

                author = value;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            return $"Type: Book\nTitle: {title}\nAuthor: {author}\nPrice: {price:f2}\n\n" +
                $"Type: GoldenEditionBook\nTitle: {title}\nAuthor: {author}\nPrice: {price + (price * 30 / 100):f2}";
        }
    }
}
