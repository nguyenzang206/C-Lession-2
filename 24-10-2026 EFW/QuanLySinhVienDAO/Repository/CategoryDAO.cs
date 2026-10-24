using System;
using System.Collections.Generic;
using System.Text;
using QuanLyThuVienDAO.Entity;

namespace QuanLyThuVienDAO.Repository
{
    public class CategoryDAO
    {
        private readonly QLTVDBContext db = new QLTVDBContext();

        public void AddCategory(Category ca)
        {
            db.Categories.Add(ca);
            db.SaveChanges();
        }
    }
}
