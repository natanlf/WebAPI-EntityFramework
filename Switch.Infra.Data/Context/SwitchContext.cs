using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Context
{   
    //A classe Context herda de DBContext
    public class SwitchContext : DbContext
    {
        //Usuarios é o nome da tabela que será criada
        public DbSet<Usuario> Usuarios { get; set; }

        //Consttrutor e acesso o construtor da classe pai e passo options
        public SwitchContext(DbContextOptions options) : base(options)
        {

        }
    }
}
