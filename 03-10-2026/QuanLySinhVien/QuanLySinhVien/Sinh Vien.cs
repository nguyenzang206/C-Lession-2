using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLySinhVien
{
    public class Sinh_Vien
    {
        [Required]
        [RegularExpression("^SV[0-9]{8}$", ErrorMessage = "MaSV must be in the format: SV followed by 8 digits.")]
        public string MaSV { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "HoTen must be between 5 and 50 characters.")]
        public string HoTen { get; set; }
        [Required]
        [RegularExpression("^CSE[0-9]{4}$", ErrorMessage = "MaLop must be in the format: CSE followed by 4 digits.")]
        public String MaLop { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }


        public String GioiTinh { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email address.")]
        public String Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public String SoDienThoai { get; set; }

        public String TrangThai { get; set; }

        public bool Validate(out List<ValidationResult> results)
        {
            var context = new ValidationContext(this);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(this, context, results, true);
        }
    }
}
