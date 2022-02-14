using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrsLibrary.Models
{
    public class Request
    {
        public int ID { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        [Required, StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [Required, StringLength(20)]
        public string DeliveryMode { get; set; } = "Pickup";
        [Required, StringLength(10)]
        public string Status { get; set; } = "NEW";
        [Required]
        public Decimal Total { get; set; } = 0;
        [Required]
        public virtual int UserID { get; set; }

        public Request() { }

        public void Review()
        {

        }

        public void Approve()
        {

        }

        public void Reject()
        {

        }

        public void GetReviews()
        {

        }
    }
}
