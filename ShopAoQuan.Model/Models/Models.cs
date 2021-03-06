using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopAoQuan.Model.Models
{
    public partial class Models : DbContext
    {
        public Models()
            : base("name=Models")
        {
        }

        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostCategory> PostCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SupportOnline> SupportOnlines { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Footer>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .HasMany(e => e.Menus)
                .WithOptional(e => e.MenuGroup)
                .HasForeignKey(e => e.GroupID);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("PostTags").MapLeftKey("PostID").MapRightKey("TagsID"));

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .HasMany(e => e.Posts)
                .WithRequired(e => e.PostCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductTags").MapLeftKey("ProductID").MapRightKey("TagID"));

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<VisitorStatistic>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);
        }
    }
}
