using System;
using Core.DominLayer.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System;
using System.Reflection;
using Core.DominLayer.Catalog;
using Core.DominLayer.Blogs;
using Core;
using Core.DominLayer.Common;
using Core.DominLayer.Media;

namespace Data.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


        }

       
        public DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public DbSet<Address> Address { get; set; }

        public DbSet<CustomerAddressMapping> CustomerAddressMapping { get; set; }

        

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }

        public DbSet<Picture> Picture { get; set; }
        public DbSet<Download> Download { get; set; }
        public DbSet<PictureBinary> PictureBinary { get; set; }
        public DbSet<ProductPicture> ProductPicture { get; set; }


        public DbSet<ProductManufacturer> ProductManufacturer { get; set; }

        public DbSet<ProductSpecificationAttribute> ProductSpecificationAttribute { get; set; }

        public DbSet<ProductAttribute> ProductAttribute { get; set; }
        public DbSet<ReviewType> ReviewType { get; set; }
        public DbSet<ProductAttributeCombination> ProductAttributeCombination { get; set; }

        public DbSet<ProductAttributeMapping> ProductAttributeMapping { get; set; }
        public DbSet<ProductAttributeValue> ProductAttributeValue { get; set; }

        //public DbSet<ProductManufacturer> ProductManufacturer { get; set; }





        public DbSet<Category> Category { get; set; }

        public DbSet<BlogComment> BlogComment { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BlogPostTag> BlogPostTag { get; set; }

        public DbSet<Setting> Setting { get; set; }





        




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.HasDefaultSchema("ClassifiedAds");



            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("CustomerRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("CustomerClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("CustomerLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("CustomerRoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("CustomerTokens");
            });

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }


}

