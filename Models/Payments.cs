using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;
    public class Payments
    {
        [Key] public Guid payment_id { get; set; }



        public int amountPaid { get; set; }

        [MaxLength(200)] public string paymentStatus { get; set; }

        public DateTime date { get; set; }

        public Guid order_id { get; set; }
        [ForeignKey("order_id")] public Order Order { get; set; }
    }
