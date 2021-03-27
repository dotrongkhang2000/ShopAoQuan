namespace ShopAoQuan.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupportOnline
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Skype { get; set; }

        [StringLength(50)]
        public string Moblie { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Facebook { get; set; }

        public bool? Status { get; set; }
    }
}
