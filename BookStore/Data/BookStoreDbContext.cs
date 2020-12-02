using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreDbContext : IdentityDbContext<BookStoreUser>
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<CartBook> CartBooks { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .Property(c => c.OrderStatus)
                .HasConversion<string>();

            builder.Entity<ProductType>()
                .Property(c => c.Name)
                .HasConversion<string>();

            builder.Entity<Category>()
                .Property(c => c.Name)
                .HasConversion<string>();

            builder.Entity<BookStoreUser>()
                .HasOne(a => a.Cart)
                .WithOne(b => b.User)
                .HasForeignKey<Cart>(a => a.UserName);

            builder.Entity<Order>()
                .HasOne(a => a.User)
                .WithMany(b => b.Orders)
                .HasForeignKey(u => u.UserName)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Book>()
                .HasOne(a => a.Author)
                .WithMany(b => b.WrittenBooks)
                .HasForeignKey(u => u.AuthorId);

            builder.Entity<Book>()
                .HasOne(a => a.Type)
                .WithMany(b => b.Books)
                .HasForeignKey(u => u.ProductTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Book>()
                .HasOne(a => a.Publisher)
                .WithMany(b => b.Books)
                .HasForeignKey(u => u.PublisherId);

            builder.Entity<Book>()
                .HasOne(a => a.Category)
                .WithMany(b => b.Books)
                .HasForeignKey(u => u.CategoryId);

            builder.Entity<Review>()
                .HasOne(a => a.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(c => c.BookId);

            builder.Entity<Review>()
                .HasOne(a => a.User)
                .WithMany(b => b.Reviews)
                .HasForeignKey(c => c.UserName);

            builder.Entity<CartBook>()
                .HasKey(a => new { a.BookId, a.CartId });
            builder.Entity<CartBook>()
                .HasOne(a => a.Book)
                .WithMany(b => b.CartBooks)
                .HasForeignKey(c => c.BookId);
            builder.Entity<CartBook>()
                .HasOne(a => a.Cart)
                .WithMany(b => b.CartBooks)
                .HasForeignKey(c => c.CartId);

            builder.Entity<OrderBook>()
                .HasKey(a => new { a.BookId, a.OrderId });
            builder.Entity<OrderBook>()
                .HasOne(a => a.Book)
                .WithMany(b => b.OrderBooks)
                .HasForeignKey(c => c.BookId);
            builder.Entity<OrderBook>()
                .HasOne(a => a.Order)
                .WithMany(b => b.OrderBooks)
                .HasForeignKey(c => c.OrderId);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "User", NormalizedName = "User" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Administrator", NormalizedName = "Admin" });

            var physicalBook = new ProductType { ProductTypeId = Guid.NewGuid(), Name = ProductTypeEnum.PhysicalBook };
            var ebook = new ProductType { ProductTypeId = Guid.NewGuid(), Name = ProductTypeEnum.Ebook };
            builder.Entity<ProductType>().HasData(physicalBook);
            builder.Entity<ProductType>().HasData(ebook);

            var action = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Action };
            var adventure = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Adventure };
            var horror = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Horror };
            var history = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.History };
            var crime = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Crime };
            var drama = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Drama };
            var fantasy = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Fantasy };
            var sf = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.SF };
            var mystery = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Mystery };
            var poetry = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Poetry };
            var romance = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Romance };
            var comedy = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Comedy };
            var thriller = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Thriller };
            var biography = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Biography };
            var autobiography = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Autobiography };
            var encyclopedia = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Encyclopedia };
            var health = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Health };
            var journal = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Journal };
            var memoir = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Memoir };
            var philosophy = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Philosophy };
            var science = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Science };
            var travel = new Category { CategoryId = Guid.NewGuid(), Name = CategoryEnum.Travel };
            builder.Entity<Category>().HasData(action);
            builder.Entity<Category>().HasData(adventure);
            builder.Entity<Category>().HasData(horror);
            builder.Entity<Category>().HasData(history);
            builder.Entity<Category>().HasData(crime);
            builder.Entity<Category>().HasData(drama);
            builder.Entity<Category>().HasData(fantasy);
            builder.Entity<Category>().HasData(sf);
            builder.Entity<Category>().HasData(mystery);
            builder.Entity<Category>().HasData(poetry);
            builder.Entity<Category>().HasData(romance);
            builder.Entity<Category>().HasData(comedy);
            builder.Entity<Category>().HasData(thriller);
            builder.Entity<Category>().HasData(biography);
            builder.Entity<Category>().HasData(autobiography);
            builder.Entity<Category>().HasData(encyclopedia);
            builder.Entity<Category>().HasData(health);
            builder.Entity<Category>().HasData(journal);
            builder.Entity<Category>().HasData(memoir);
            builder.Entity<Category>().HasData(philosophy);
            builder.Entity<Category>().HasData(science);
            builder.Entity<Category>().HasData(travel);

            base.OnModelCreating(builder);
        }
    }
}
