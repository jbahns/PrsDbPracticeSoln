using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrsLibrary.Models
{
    public class RequestLine
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }  

        public virtual Request Request { get; set; }
        public virtual Product Product { get; set; }

        public RequestLine() { }

        private void RecalculateRequestTotal()
        {

        }
    }
}
