using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig { Key = "HomeDescription", Value = "This is description of eShopSolution" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language { Id = "vi-VN", Name="Tiếng Việt",IsDefault=true},
                new Language { Id = "en-US", Name="English",IsDefault=false}
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation { Id = 1, CategoryId = 1, Name = "Áo Nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam", SeoAlias = "ao-nam", LanguageId = "vi-VN" },
                new CategoryTranslation { Id = 2, CategoryId = 1, Name = "Men Shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men", SeoAlias = "men-shirt", LanguageId = "en-US" },
                new CategoryTranslation { Id = 3, CategoryId = 2, Name = "Áo Nữ", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ", SeoAlias = "ao-nu", LanguageId = "vi-VN" },
                new CategoryTranslation { Id = 4, CategoryId = 2, Name = "Women Shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women", SeoAlias = "women-shiet", LanguageId = "en-US" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product {Id = 1, Price = 200000 ,Stock = 0, OriginalPrice = 100000, ViewCount = 0, DateCreated = DateTime.Now }

            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation 
                { 
                    Id = 1, 
                    ProductId = 1, 
                    Name= "Áo sơ mi nam Việt Tiến" ,
                    Description = "Áo sơ mi nam Việt Tiến",
                    Detail = "Áo sơ mi nam Việt Tiến", 
                    SeoDescription = "Áo sơ mi nam Việt Tiến", 
                    SeoAlias = "ao-so-mi-nam-viet-tien" , 
                    SeoTitle = "Áo sơ mi nam Việt Tiến",
                    LanguageId = "vi-VN"
                },
                new ProductTranslation
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "VietTien Men T-Shirt",
                    Description = "VietTien Men T-Shirt",
                    Detail = "VietTien Men T-Shirt",
                    SeoDescription = "VietTien Men T-Shirt",
                    SeoAlias = "viet-tien-men-t-shirt",
                    SeoTitle = "VietTien Men T-Shirt",
                    LanguageId = "en-US"
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory { CategoryId = 1 ,ProductId = 1}
            ) ;
        }
    }
}
