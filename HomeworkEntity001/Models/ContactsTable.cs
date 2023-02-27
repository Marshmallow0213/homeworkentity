namespace HomeworkEntity001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        public int Id { get; set; }

        [Column("Product ID")]
        [Required]
        [StringLength(50)]
        public string Product_ID { get; set; }

        [Column("Product Name")]
        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Count { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }

        [Column("Product Category")]
        [Required]
        [StringLength(50)]
        public string Product_Category { get; set; }
    }
}
