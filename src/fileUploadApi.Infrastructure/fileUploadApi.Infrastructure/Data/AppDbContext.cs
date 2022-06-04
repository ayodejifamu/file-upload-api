using Microsoft.EntityFrameworkCore;
using fileUploadApi.SharedKernel.Entities;
namespace fileUploadApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<userIdfile> fileInfo { get; set; }
        public DbSet<fileTypeControl> fileTypeInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //userIdfile Model Builder

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.fileUniqueId)
            .HasColumnName("fileUniqueId");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.userUniqueId)
            .HasColumnName("userUniqueId");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.fileTypeId)
            .HasColumnName("fileTypeId");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.filename)
            .HasColumnName("filename");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.fileTypeExtension)
            .HasColumnName("fileTypeExtension");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.updatedFileName)
            .HasColumnName("updatedFileName");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.filePath)
            .HasColumnName("filePath");

            modelBuilder.Entity<userIdfile>()
            .Property(b => b.filePath)
            .HasColumnName("fileDataBS64");


            //fileTypeControl Model builder
            modelBuilder.Entity<fileTypeControl>()
            .HasKey(b => b.baseId)
            .HasName("baseId");

            modelBuilder.Entity<fileTypeControl>()
            .Property(b => b.fileType)
            .HasColumnName("fileType");

            modelBuilder.Entity<fileTypeControl>()
            .Property(b => b.fileTypeAcceptableExtensions)
            .HasColumnName("fileTypeAcceptableExtensions");

            modelBuilder.Entity<fileTypeControl>()
            .Property(b => b.maxFileSizeToLetSaveInDb)
            .HasColumnName("maxFileSizeToLetSaveInDb");
        }
    }


}