using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers
{
    public class VendorsController
    {
        private readonly PrsDbContext _context;

        public VendorsController(PrsDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetByPk(int id)
        {
            return _context.Vendors.Find(id);
        }
        public Vendor Create(Vendor vendor)
        {
            if (vendor is null)
            {
                throw new ArgumentNullException("Vendor cannot be null");
            }
            if (vendor.ID != 0)
            {
                throw new ArgumentException("Vendor.ID must be zero");
            }
            _context.Add(vendor);
            _context.SaveChanges();

            return vendor;
        }

        public void Change(Vendor vendor)
        {
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor is null)
            {
                throw new Exception("Vendor not found");
            }
            _context.Remove(vendor);
            _context.SaveChanges();
        }
    }
}
