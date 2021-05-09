namespace Eweb0750080129.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int productID { get; set; }

        [StringLength(200)]
        public string productName { get; set; }

        public int? productPrice { get; set; }

        [StringLength(200)]
        public string url { get; set; }
    }
}
