using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace QuanLyThuVienDAO.Entity
{
        public class Category
        {
            public int Id { get; set; }
            public string Description { get; set; } = string.Empty;

            // Một Category có nhiều Book
            public virtual ICollection<Book> Books { get; set; }
                = new List<Book>();
        }
}

