using DGFScouting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace DGFScouting.Data
{
    public class RecruitsDbContext : DbContext
    {
        public DbSet<Recruit> Recruits { get; set; }
        public DbSet<CommittedPlayer> CommittedPlayers { get; set; }
    }
}