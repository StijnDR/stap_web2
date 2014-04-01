using System;
using System.Collections.Generic;
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
    }
}