using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacFoods;

public class ComandaDBContext : DbContext
{
    //1 Construtor do banco de dados
    public ComandaDBContext() : base()
    {
        
    }
    //2 Configurar conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //2.1 String de conexão
        var conexao = "Server=localhost;Database=Senac_Foods;User=root;Password=";
        //2.2 Configuras o provedor de banco de dados
        optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CardapioItem> CardapioItems { get; set; }
    public DbSet<Mesa> Mesas { get; set; }
    public DbSet<Comanda> Comandas { get; set; }
    public DbSet<ComandaItem> ComandasItem { get; set; }
    public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
    public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
}
