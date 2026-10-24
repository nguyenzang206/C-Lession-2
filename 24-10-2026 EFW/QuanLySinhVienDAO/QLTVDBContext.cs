using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QuanLyThuVienDAO.Entity;

namespace QuanLyThuVienDAO
{
    public class QLTVDBContext : DbContext
    {
        public QLTVDBContext()
        {
        }

        public QLTVDBContext(DbContextOptions<QLTVDBContext> options)
            : base(options)
        {
        }

        // Khai báo các DbSet
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<BookCopy> BookCopies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = GetConnectionString();
                optionsBuilder.UseMySQL(connectionString);
            }
        }

        public static string GetConnectionString()
        {
            // 1. Đọc từ biến môi trường Process, User hoặc Machine (Bảo mật: Không lưu mật khẩu trong source code)
            string? connStr = Environment.GetEnvironmentVariable("QLTV_CONNECTION_STRING", EnvironmentVariableTarget.Process)
                           ?? Environment.GetEnvironmentVariable("QLTV_CONNECTION_STRING", EnvironmentVariableTarget.User)
                           ?? Environment.GetEnvironmentVariable("QLTV_CONNECTION_STRING", EnvironmentVariableTarget.Machine)
                           ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

            if (!string.IsNullOrWhiteSpace(connStr))
            {
                return connStr;
            }

            // 2. Đọc từ file appsettings.json nếu có
            try
            {
                var basePath = AppContext.BaseDirectory;
                var builder = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                    .AddEnvironmentVariables();

                var config = builder.Build();
                connStr = config.GetConnectionString("DefaultConnection");
            }
            catch
            {
                // Fallback nếu không tải được configuration provider
            }

            // 3. Ghép mật khẩu từ biến môi trường MYSQL_PWD nếu chuỗi kết nối chưa có Pwd
            string pwd = Environment.GetEnvironmentVariable("MYSQL_PWD", EnvironmentVariableTarget.Process)
                      ?? Environment.GetEnvironmentVariable("MYSQL_PWD", EnvironmentVariableTarget.User)
                      ?? "";

            if (!string.IsNullOrWhiteSpace(connStr))
            {
                if (!connStr.Contains("Pwd=", StringComparison.OrdinalIgnoreCase) &&
                    !connStr.Contains("Password=", StringComparison.OrdinalIgnoreCase))
                {
                    connStr = connStr.TrimEnd(';') + $";Pwd={pwd};";
                }
                return connStr;
            }

            return $"Server=localhost;Port=3306;Database=QuanLyThuVienDB;Uid=root;Pwd={pwd};";
        }

        // Cấu hình quan hệ giữa các bảng
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình Category và quan hệ: Một Category có nhiều Book (1 - N)
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Description)
                      .HasMaxLength(255);

                entity.HasMany(c => c.Books)
                      .WithOne(b => b.Category)
                      .HasForeignKey(b => b.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Cấu hình Book và quan hệ: Một Book có nhiều BookCopy (1 - N)
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(255);
                entity.Property(b => b.Publisher)
                      .HasMaxLength(255);
                entity.Property(b => b.Author)
                      .HasMaxLength(255);
                entity.Property(b => b.Price)
                      .HasPrecision(18, 2);

                entity.HasMany(b => b.BookCopies)
                      .WithOne(bc => bc.Book)
                      .HasForeignKey(bc => bc.BookId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Cấu hình BookCopy
            modelBuilder.Entity<BookCopy>(entity =>
            {
                entity.HasKey(bc => bc.Id);
                entity.Property(bc => bc.Status)
                      .HasMaxLength(100);
                entity.Property(bc => bc.Condition)
                      .HasMaxLength(100);
            });
        }
    }

    // Factory hỗ trợ Design-time cho EF Core Migrations
    public class QLTVDBContextFactory : IDesignTimeDbContextFactory<QLTVDBContext>
    {
        public QLTVDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QLTVDBContext>();
            string connStr = QLTVDBContext.GetConnectionString();
            optionsBuilder.UseMySQL(connStr);
            return new QLTVDBContext(optionsBuilder.Options);
        }
    }
}
