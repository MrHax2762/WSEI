using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;



namespace WindowsFormsApplication1
{




    public class FirmaContext : DbContext
    {
        public FirmaContext()
            : base("Data Source=.\\SQLEXPRESS;Initial Catalog=codefirst;Integrated Security=True;") 
    {
    }

    public DbSet<Firma> Firmy { get; set; }
        
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
    }


    }
}
