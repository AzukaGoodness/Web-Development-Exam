using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data.MappingConfiguration
{
    public static class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("First_Name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100).HasColumnName("Last_Name");
            modelBuilder.Entity<Customer>().Property(c => c.Middlename).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Maritalstatus).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.Gender).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.Country).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.State).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.city).IsRequired(true).HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(c => c.SubmissionDate).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(c => c.BirthDate).IsRequired(true);


            
            
            return modelBuilder;


        }

  
        }
    }

