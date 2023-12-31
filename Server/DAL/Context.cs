﻿using Microsoft.EntityFrameworkCore;
using TicketsConDetalles.Shared.Models;


namespace TicketsConDetalles.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }

    }
}
