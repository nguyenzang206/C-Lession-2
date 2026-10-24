using QuanLyThuVienDAO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVienDAO.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int NumberOfCopies { get; set; }
        public string Author { get; set; } = string.Empty;
        public int PublicationYear { get; set; }

        // Khóa ngoại liên kết Category
        public int CategoryId { get; set; }

        // Nhiều Book thuộc một Category
        public virtual Category Category { get; set; } = null!;

        // Một Book có nhiều BookCopy
        public virtual ICollection<BookCopy> BookCopies { get; set; }
            = new List<BookCopy>();
    }
}
