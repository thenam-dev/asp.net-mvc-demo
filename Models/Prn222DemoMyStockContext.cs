using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _15_NguyenTheNam_MVC_Product_DataFirst.Models;

public partial class Prn222DemoMyStockContext : DbContext
{
    public Prn222DemoMyStockContext()
    {
    }

    public Prn222DemoMyStockContext(DbContextOptions<Prn222DemoMyStockContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Name=PRN222_Demo_MyStock");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6EDF3DE5453");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
