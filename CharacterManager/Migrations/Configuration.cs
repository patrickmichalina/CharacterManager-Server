using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CharacterManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.Context context)
        {
            
        }
    }
}
