using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVienDAO.Entity
{
    public class BookCopy
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;

        // Khóa ngoại liên kết Book
        public int BookId { get; set; }

        // Nhiều BookCopy thuộc một Book
        public virtual Book Book { get; set; } = null!;
    }
}
