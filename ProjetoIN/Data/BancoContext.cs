using Microsoft.EntityFrameworkCore;
using ProjetoIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIN.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {
        }

        public DbSet<CadastroModel> Cadastro { get; set; }
    }
}
