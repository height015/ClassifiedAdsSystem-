using System;
using Core.DominLayer.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class BlogPostBuilder : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Body).IsRequired();
            builder.Property(p => p.MetaKeywords).IsRequired();
        }


    }
}

