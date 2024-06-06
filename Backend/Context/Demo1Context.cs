//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Backend.Models;

//public partial class Demo1Context : DbContext
//{
//    public Demo1Context()
//    {
//    }

//    public Demo1Context(DbContextOptions<Demo1Context> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<TblProduct> TblProducts { get; set; }

//    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

//    public virtual DbSet<TblUser> TblUsers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:AssetsProjectContext");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<TblProduct>(entity =>
//        {
//            entity.ToTable("TBL_product");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Name)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("name");
//            entity.Property(e => e.Price)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("price");
//            entity.Property(e => e.Quantity).HasColumnName("quantity");
//        });

//        modelBuilder.Entity<TblTransaction>(entity =>
//        {
//            entity.ToTable("TBL_transaction");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.ProductId).HasColumnName("product_id");
//            entity.Property(e => e.Quantity).HasColumnName("quantity");
//            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
//            entity.Property(e => e.TransactionDate)
//                .HasDefaultValueSql("(getdate())")
//                .HasColumnType("date")
//                .HasColumnName("transaction_date");
//            entity.Property(e => e.UserId).HasColumnName("user_id");

//            entity.HasOne(d => d.Product).WithMany(p => p.TblTransactions)
//                .HasForeignKey(d => d.ProductId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_TBL_transaction_TBL_product");

//            entity.HasOne(d => d.User).WithMany(p => p.TblTransactions)
//                .HasForeignKey(d => d.UserId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_TBL_transaction_TBL_user");
//        });

//        modelBuilder.Entity<TblUser>(entity =>
//        {
//            entity.ToTable("TBL_user");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Balance).HasColumnName("balance");
//            entity.Property(e => e.Username)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("username");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
