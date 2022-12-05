using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._04
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public Book()
        {

        }
        public string Title { get { return title; } set { title = value; } }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = pages = value <= 0 ? 1 : value;
            }
        }
        public string Category { get { return category; } set { category = value; } }
        public string Author { get { return author; } set { author = value; } }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;

            }
            set
            {
                releaseDate = releaseDate = value <= 1450 || value >= 2021 ? -1 : value;
            }
        }
        public override string ToString()
        {
            return String.Format($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}");
        }
    }
}