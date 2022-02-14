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
        [Required]
        public virtual int RequestID { get; set; }
        [Required]
        public virtual int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }  

        public RequestLine() { }

        private void RecalculateRequestTotal()
        {

        }
    }
}
