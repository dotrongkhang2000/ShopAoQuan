namespace ShopAoQuan.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Footer
    {
        [StringLength(250)]
        public string ID { get; set; }

        public string Content { get; set; }
    }
}
