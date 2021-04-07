﻿using Microsoft.AspNet.Identity.EntityFramework;
using ShopAoQuan.Model.Models;
using System.Data.Entity;

namespace ShopAoQuan.Data
{
    public class ShopAoQuanDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShopAoQuanDbContext() : base("ShopAoQuanConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<Error> Errors { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        //Phuong thuc tao moi chinh no de thao tac voi Indentity
        public static ShopAoQuanDbContext Create()
        {
            return new ShopAoQuanDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId});
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId); 
        }
    }
}