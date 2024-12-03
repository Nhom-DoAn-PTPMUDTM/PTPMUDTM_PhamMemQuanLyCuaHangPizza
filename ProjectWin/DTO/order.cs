using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{
    [Table("orders")]
    public partial class Order
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            order_items = new HashSet<OrderItems>();
        }

        [Key]
        public int order_id { get; set; }

        public int? user_id { get; set; }

        [StringLength(255)]
        public string shipping_address { get; set; }

        [StringLength(20)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string full_name { get; set; }

        public decimal? total_price { get; set; }

        public int? total_quantity { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> order_items { get; set; }

        public virtual User user { get; set; }
    }
}
