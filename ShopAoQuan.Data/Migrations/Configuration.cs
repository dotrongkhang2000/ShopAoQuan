namespace ShopAoQuan.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShopAoQuan.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopAoQuan.Data.ShopAoQuanDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopAoQuan.Data.ShopAoQuanDbContext context)
        {
            CreateProductCategorySample(context);
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopAoQuanDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopAoQuanDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "test",
            //    Email = "test.international@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "test01"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("test.international@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

            
        }

        private void CreateProductCategorySample(ShopAoQuan.Data.ShopAoQuanDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>
            {
                new ProductCategory()
                {
                    Name = "Điện Lạnh",Alias = "dien-lanh",Status=true
                },
                new ProductCategory()
                {
                    Name = "Viễn Thông",Alias = "vien-thong",Status=true
                },
                new ProductCategory()
                {
                    Name = "Đồ gia dụng",Alias = "do-gia-dung",Status=true
                },
                new ProductCategory()
                {
                    Name = "Mỹ phẩm",Alias = "my-pham",Status=true
                }

            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
            
        }
    }
}
