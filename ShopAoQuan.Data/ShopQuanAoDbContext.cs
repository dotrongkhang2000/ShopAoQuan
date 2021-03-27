using ShopAoQuan.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAoQuan.Data
{
    public class ShopQuanAoDbContext : DbContext
    {
        //Contractor
        public ShopQuanAoDbContext() : base("ShopAoQuanConnection") {
            //Khi load bang cha thi khong lam trong bang con
            this.Configuration.LazyLoadingEnabled = false;
            }
        public DbSet<Footer>  Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        //Chay khi khoi tao Emtity FrameWork
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
