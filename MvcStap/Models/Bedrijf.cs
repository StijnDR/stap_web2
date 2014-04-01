using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcStap.Models
{
    public class Bedrijf
    {
        // Bedrijf gegevens
        private String naamBedrijf;
        private String adresBedrijf;
        private String gemeenteBedrijf;
        private String urlBedrijf;
        private String bereikbaarheidBedrijf;
        private String omschrijvingBedrijf;
        
        // Contact gegevens 
        private String naamContact;
        private String emailContact;
        private String telefoonContact;

        private String wachtwoordContact;

        //Stages
        public virtual ICollection<Stage> Stages { get; private set; }

        #region Constructors
        public Bedrijf()
        {
            Stages = new List<Stage>();
        }

        public Bedrijf(string naamB, string adresB, string gemeenteB, string urlB, string bereikbaarheadB, string omschrijvingB,
                        string naamC, string emailC, string telefoonC, string wachtwoordC)
        {
            this.adresBedrijf = adresB;
            this.gemeenteBedrijf = gemeenteB;
            this.urlBedrijf = urlB;
            this.bereikbaarheidBedrijf = bereikbaarheadB;
            this.omschrijvingBedrijf = omschrijvingB;

            this.naamContact = naamC;
            this.emailContact = emailC;
            this.telefoonContact = telefoonC;
            this.wachtwoordContact = wachtwoordC;
        }
        #endregion

        public class RegisterModel
        {
           
            

            // Bedrijf gegevens
            [Required]
            [Display(Name = "Bedrijfsnaam")]
            public string naamBedrijf { get; set; }

            [Required]
            [Display(Name = "Adres")]
            public String adresBedrijf;

            [Required]
            [Display(Name = "Gemeente")]
            public String gemeenteBedrijf;

            [Required]
            [Display(Name = "Website")]
            public String urlBedrijf;

            [Required]
            [Display(Name = "Bereikbaarheid")]
            public String bereikbaarheidBedrijf;

            [Required]
            [Display(Name = "Omschrijving")]
            public String omschrijvingBedrijf;

            // Contact gegevens 
            [Required]
            [Display(Name = "Naam contactpersoon")]
            public String naamContact;

            [Required]
            [Display(Name = "Email contactpersoon")]
            public String emailContact;

            [Required]
            [Display(Name = "Telefoon contactpersoon")]
            public String telefoonContact;


            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string wachtwoordContact { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmWachtwoordContact { get; set; }
        }
    }
}