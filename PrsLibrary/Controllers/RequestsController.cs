using Microsoft.EntityFrameworkCore;
using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers
{
    class RequestsController
    {
        private readonly PrsDbContext _context;

        public RequestsController(PrsDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Request> GetAll()
        {
            return _context.Requests.Include(x => x.User).ToList();
        }

        public Request GetByPk(int id)
        {
            return _context.Requests.Include(x => x.User).SingleOrDefault(x => x.ID == id);
        }
        public Request Create(Request request)
        {
            if (request is null)
            {
                throw new ArgumentNullException("Request cannot be null");
            }
            if (request.ID != 0)
            {
                throw new ArgumentException("Request.ID must be zero");
            }
            _context.Add(request);
            _context.SaveChanges();

            return request;
        }

        public void Change(Request request)
        {
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var request = _context.Requests.Find(id);
            if (request is null)
            {
                throw new Exception("Request not found");
            }
            _context.Remove(request);
            _context.SaveChanges();
        }
    }
}
