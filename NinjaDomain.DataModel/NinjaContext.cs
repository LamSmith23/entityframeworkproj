using NinjaDomain.Classes;
using NinjaDomain.Classes.Enums;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace NinjaDomain.DataModel
{
    public class NinjaContext:DbContext
    {
        //collection of entities
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
