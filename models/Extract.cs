using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs15.models {
    public class Extract {

        public DateTime dateExtract;
        public MedicalCard medicalCard;
        public String reason;

        public Extract(MedicalCard medicalCard, DateTime dateExtract, String reason) {
            this.medicalCard = medicalCard;
            this.dateExtract = dateExtract;
            this.reason = reason;
        }

    }
}
