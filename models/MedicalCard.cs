using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs15.models {

    public class MedicalCard {
        public String name, surname, patronymic;
        public int age;
        public String direction;
        public DateTime dateEntry;
        public String additionalDescription;
        public List<Chamber> chambers = new List<Chamber>();
        public Extract extract = null;

        public void SetChamber(Chamber chamber) {
            chambers.Add(chamber);
        }

        public Chamber GetCurrentChamber() {
            return chambers[chambers.Count - 1];
        }

        public bool IsExtracted() {
            return extract != null;
        }

        public override string ToString() {
            return "ПІБ: " + name + " " + surname + " " + patronymic + " Вік: " + age;
        }

    }
}
