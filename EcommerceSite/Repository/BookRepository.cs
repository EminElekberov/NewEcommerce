using EcommerceSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly SyteDbContext _context = null;
        private readonly IConfiguration _configuration;
        public BookRepository(SyteDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<int> AddNewBook(Product model)
        {
            var newBook = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Percent=model.Percent,
                PresentPrice = model.PresentPrice,
                PastPrice = model.PastPrice,
                Image = model.Image,
                SizeToProducts = model.SizeToProducts,
                CategoryId=model.CategoryId
            };

            newBook.ProductPictureGalleries = new List<ProductPictureGallery>();

            foreach (var file in model.ProductPictureGalleries)
            {
                newBook.ProductPictureGalleries.Add(new ProductPictureGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }


            await _context.Products.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task<List<Product>> GetAllBooks()
        {
            return await _context.Products
                  .Select(model => new Product()
                  {
                      Name = model.Name,
                      Description = model.Description,
                      Percent = model.Percent,
                      PresentPrice = model.PresentPrice,
                      PastPrice = model.PastPrice,
                      Image = model.Image,
                      SizeToProducts = model.SizeToProducts,
                      CategoryId = model.CategoryId
                  }).ToListAsync();
        }

        public string GetAppName()
        {
            return _configuration["AppName"];
        }

        public async Task<Product> GetBookById(int id)
        {
            return await _context.Products.Include(x => x.ProductPictureGalleries).FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<List<Product>> GetTopBooksAsync(int count)
        {
            return await _context.Products
                  .Select(model => new Product()
                  {
                      Name = model.Name,
                      Description = model.Description,
                      Percent = model.Percent,
                      PresentPrice = model.PresentPrice,
                      PastPrice = model.PastPrice,
                      Image = model.Image,
                      SizeToProducts = model.SizeToProducts,
                      CategoryId = model.CategoryId
                  }).Take(count).ToListAsync();
        }
        public List<Product> SearchBook(string title, string authorName)
        {
            throw new NotImplementedException();
        }
    }
}
