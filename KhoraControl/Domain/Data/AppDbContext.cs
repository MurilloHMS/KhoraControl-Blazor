using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhoraControl.Domain.Models;
using KhoraControl.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

namespace KhoraControl.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountPolicy> UserAccountPolicies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            var baseUser = new UserAccount
            {
                Id = 1,
                UserName = "admin",
                Password = "Admin",
            };

            modelBuilder.Entity<UserAccount>().HasData(baseUser);

            var demoUserAccountPolicies = new UserAccountPolicy[]
            {
                new UserAccountPolicy{ Id = 1, UserAccountId = 1, UserPolicy = UserPolicy.VIEW_PRODUCT, IsEnabled = true },
                new UserAccountPolicy{ Id = 2, UserAccountId = 1, UserPolicy = UserPolicy.UPDATE_PRODUCT, IsEnabled = true },
                new UserAccountPolicy{ Id = 3, UserAccountId = 1, UserPolicy = UserPolicy.DELETE_PRODUCT, IsEnabled = true },
                new UserAccountPolicy{ Id = 4, UserAccountId = 1, UserPolicy = UserPolicy.CREATE_PRODUCT, IsEnabled = true },
            };

            modelBuilder.Entity<UserAccountPolicy>().HasData(demoUserAccountPolicies);
        }

    }
}
