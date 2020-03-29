using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Contexto:DbContext
    {
        public DbSet<HabitacionModel> habitaciones { get; set; }
        public DbSet<PacientesModel> pacientes { get; set; }
        public DbSet<MedicosModel> medicos { get; set; }
    }
}