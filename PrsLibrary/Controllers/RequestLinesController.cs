using Microsoft.EntityFrameworkCore;
using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers
{
    class RequestLinesController
    {
        private readonly PrsDbContext _context;

        public RequestLinesController(PrsDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<RequestLine> GetAll()
        {
            return _context.RequestLines.Include(x => x.Product).Include(x => x.Request).ToList();
        }

        public RequestLine GetByPk(int id)
        {
            return _context.RequestLines.Include(x => x.Product).Include(x => x.Request).SingleOrDefault(x => x.ID == id);
        }
        public RequestLine Create(RequestLine requestLine)
        {
            if (requestLine is null)
            {
                throw new ArgumentNullException("RequestLine cannot be null");
            }
            if (requestLine.ID != 0)
            {
                throw new ArgumentException("RequestLine.ID must be zero");
            }
            _context.Add(requestLine);
            _context.SaveChanges();

            return requestLine;
        }

        public void Change(RequestLine requestLine)
        {
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var requestLine = _context.RequestLines.Find(id);
            if (requestLine is null)
            {
                throw new Exception("RequestLine not found");
            }
            _context.Remove(requestLine);
            _context.SaveChanges();
        }
    }
}
