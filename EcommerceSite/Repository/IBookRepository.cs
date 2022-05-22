using EcommerceSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Repository
{
   public interface IBookRepository
    {
        Task<int> AddNewBook(Product model);
       // Task<Books> AddNewBooks(Category model);
        Task<List<Product>> GetAllBooks();
        Task<Product> GetBookById(int id);
        Task<List<Product>> GetTopBooksAsync(int count);
        List<Product> SearchBook(string title, string authorName);

        string GetAppName();
    }
}
