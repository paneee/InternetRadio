using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternetRadio.Models;

namespace InternetRadio.Data
{
    public class InternetRadioContext : DbContext
    {
        public InternetRadioContext (DbContextOptions<InternetRadioContext> options)
            : base(options)
        {
        }

        public DbSet<InternetRadio.Models.Class> Class { get; set; }
    }
}
