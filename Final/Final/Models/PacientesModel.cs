using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class PacientesModel
    {
        public int Id { get; set; }
        public int Cédula { get; set; }
        public string Nombre { get; set; }
        public Boolean Asegurado { get; set; }
        public MedicosModel Medicos { get; set; }
        public int? MedicoId { get; set; }
        public HabitacionModel Habitacion { get; set; }
        public int? HabitacionId { get; set; }

    }
}