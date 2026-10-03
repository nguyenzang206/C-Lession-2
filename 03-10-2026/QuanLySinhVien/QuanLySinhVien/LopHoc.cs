using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien
{
    public class LopHoc
    {
        public LopHoc()
        {
            Students = new List<Sinh_Vien>();
        }

        [Required]
        [RegularExpression("^CSE[0-9]{4}$", ErrorMessage = "MaLop must be in the format: CSE followed by 4 digits.")]
        public string MaLop { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "TenLop must be between 3 and 100 characters.")]
        public string TenLop { get; set; }

        public List<Sinh_Vien> Students { get; set; }

        public override string ToString()
        {
            return $"{MaLop} - {TenLop}";
        }
    }
}

