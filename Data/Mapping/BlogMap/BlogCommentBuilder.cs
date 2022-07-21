using System;
using Core.DominLayer.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class BlogCommentBuilder : IEntityTypeConfiguration<BlogComment>
    {


        public void Configure(EntityTypeBuilder<BlogComment> builder)
        {

            builder.Property(p => p.CustomerId)
                .IsRequired();

            builder.Property(p => p.BlogPostId).IsRequired();


        }
    }
}

