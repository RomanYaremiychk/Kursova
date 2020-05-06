using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs15.models {
    public class Chamber {
        public int number;
        public String numberTel;
        public DateTime dateEntry;

        public Chamber(int number, String numberTel, DateTime dateEntry) {
            this.number = number;
            this.numberTel = numberTel;
            this.dateEntry = dateEntry;
        }

        public override string ToString() {
            return number + " | " + numberTel;
        }
    }
}
