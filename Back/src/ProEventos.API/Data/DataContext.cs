using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.API;
using ProEventos.API.Models;
using Microsoft.EntityFrameworkCore;




namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        
        public DbSet<Evento> Eventos { get; set; }
    }
}