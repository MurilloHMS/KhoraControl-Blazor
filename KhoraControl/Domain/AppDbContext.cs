using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhoraControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

namespace KhoraControl.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<MenuAcessos> menuAcessos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuAcessos>()
                .HasKey(ma => new { ma.Id_Usuario, ma.Id_Opcao });

            base.OnModelCreating(modelBuilder);
        }

        public void VerificarBanco()
        {
            try
            {
                Database.EnsureCreated();
                PreencherDados();

            }
            catch (Exception ex)
            {
                //MessageBox.("Erro ao criar ou popular o banco de dados:");
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
            }


        }

        private void PreencherDados()
        {
            if (!Usuarios.Any())
            {
                Usuarios.AddRange(
                    new Usuarios
                    {
                        Nome = "Admin",
                        Email = "admin@outlook.com",
                        Senha = "Admin",
                        Ativo = 'T'
                    },
                    new Usuarios
                    {
                        Nome = "Suporte",
                        Email = "Suporte@Outlook.com",
                        Senha = "Xj7hpmtmma@",
                        Ativo = 'T'
                    }
                );
                SaveChanges();
            }
            if (!menuAcessos.Any())
            {
                menuAcessos.AddRange(
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 1,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 2,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 3,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 4,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 5,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 6,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 7,
                        ID = 1,
                        Liberado = 'T'
                    }

                );
                SaveChanges();
            }
        }

    }
}
