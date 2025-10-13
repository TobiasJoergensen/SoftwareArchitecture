using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratorService.Migrations
{
    internal interface IMigrator
    {
        void PerformMigrations();
    }
}
