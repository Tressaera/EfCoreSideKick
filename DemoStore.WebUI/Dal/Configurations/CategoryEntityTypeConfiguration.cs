using DemoStore.WebUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DemoStore.WebUI
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(x => x.CategoryId);

            builder
                .Property(x => x.CategoryId)
                .HasColumnName("CategoryId")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.CategoryName)
                .HasColumnName("CategoryName")
                .IsUnicode(true);

            builder
                .Property(x => x.CategoryStatus)
                .HasColumnName("CategoryStatus");

            builder
                .ToTable("Category", "dbo");
        }
    }
}
