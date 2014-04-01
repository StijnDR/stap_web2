using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcStap.Models
{
    public class Stage
    {
        public int ID { get; set; }
        public string Titel { get; set; }
        [Display(Name = "Omschrijving")]
        public string OmschrijvingOpdracht { get; set; }
        [Display(Name = "Specialisatie")]
        public string SpecialisatieOpdracht { get; set; }
        public string Semester { get; set; }
        [Display(Name = "Aantal studenten")]
        public string AantalStudentenOpdracht { get; set; }
        public string Stagementor { get; set; }
    }

    public class StageDBContext : DbContext
    {
        public DbSet<Stage> Stages { get; set; }
    }

}