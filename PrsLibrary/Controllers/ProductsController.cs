using Microsoft.EntityFrameworkCore;
using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers
{
    public class ProductsController
    {
        private readonly PrsDbContext _context;

        public ProductsController(PrsDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Include(x => x.Vendor).ToList();
        }

        public Product GetByPk(int id)
        {
            return _context.Products.Include(x => x.Vendor).SingleOrDefault(x => x.ID == id);
        }
        public Product Create(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException("Product cannot be null");
            }
            if (product.ID != 0)
            {
                throw new ArgumentException("Product.ID must be zero");
            }
            _context.Add(product);
            _context.SaveChanges();

            return product;
        }

        public void Change(Product product)
        {
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var product = _context.Products.Find(id);
            if (product is null)
            {
                throw new Exception("Product not found");
            }
            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}
