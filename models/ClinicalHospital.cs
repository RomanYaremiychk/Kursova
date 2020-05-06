using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs15.models {
    class ClinicalHospital {

        public List<MedicalCard> medicalCards = new List<MedicalCard>();
        public List<Chamber> chambers = new List<Chamber>();

        public ClinicalHospital() {
            createCardTEST("n1", "s1", "p1");
            createCardTEST("n2", "s2", "p2");
            createCardTEST("n3", "s3", "p3");
            createCardTEST("n4", "s4", "p4");
            createCardTEST("n5", "s5", "p5");
        }

        public bool RegisterMedicalCard(MedicalCard medicalCard) {
            if (medicalCard.name != "" && medicalCard.surname != "" && medicalCard.patronymic != "" &&
                medicalCard.direction != "" && medicalCard.age > 0 && medicalCard.chambers.Count > 0) {
                medicalCards.Add(medicalCard);
                Console.WriteLine("Medical card is created: " + medicalCard);

                return true;
            }

            return false;
        }

        public void Extract(MedicalCard medicalCard) {
            //medicalCard.extract =
        }

        public bool RegisterChamber(Chamber chamber) {
            if(GetChamber(chamber.number) == null && chamber.numberTel != "") {
                chambers.Add(chamber);
                return true;
            } else {
                return false;
            }
        }

        public Chamber GetChamber(int number) {

            foreach(Chamber chamber in chambers) {
                if(chamber.number == number) {
                    return chamber;
                }
            }

            return null;
        }

        public void createCardTEST(String name, String surname, String patronymic) {
            MedicalCard card = new MedicalCard();
            card.name = name;
            card.surname = surname;
            card.patronymic = patronymic;
            RegisterMedicalCard(card);
        }

        public static List<MedicalCard> GetCardsByPIB(List<MedicalCard> cards, String name, String surname, String patronymic) {
            List<MedicalCard> result = new List<MedicalCard>();

            foreach (MedicalCard card in cards) {
                if ((card.name == name || name == "") && (card.surname == surname || surname == "")
                    && (card.patronymic == patronymic || patronymic == "")) {
                    result.Add(card);
                }
            }

            return result;
        }

        public static List<MedicalCard> GetCardsByDate(List<MedicalCard> cards, DateTime dateTime, bool active = true) {
            List<MedicalCard> result = new List<MedicalCard>();

            if (active) {
                foreach (MedicalCard card in cards) {
                    if (!card.IsExtracted() && IsBetween(dateTime, card.dateEntry, card.extract.dateExtract)) {
                        result.Add(card);
                    }
                }
            } else {
                result = cards;
            }

            return result;
        }

        //public static List<MedicalCard> GetCardsByDataEntry(List<MedicalCard> cards, bool active = true) {
        //    List<MedicalCard> result = new List<MedicalCard>();

        //    if(active) {
        //        foreach(MedicalCard card in cards) {
                    
        //        }
        //    }

        //    return result;
        //}

        public static List<MedicalCard> GetCardsExtracted(List<MedicalCard> cards) {
            List<MedicalCard> result = new List<MedicalCard>();

                foreach(MedicalCard card in cards) {
                    if(card.extract != null) {
                        result.Add(card);
                    }
                }

            return result;
        }

        public static List<MedicalCard> GetCardsNotExtracted(List<MedicalCard> cards) {
            List<MedicalCard> result = new List<MedicalCard>();

                foreach (MedicalCard card in cards) {
                    if (card.extract == null) {
                        result.Add(card);
                    }
                }

            return result;
        }

        public static List<MedicalCard> GetCardsByAge(List<MedicalCard> cards, int ageFrom, int ageTo, bool active) {
            List<MedicalCard> result = new List<MedicalCard>();

            if (active) {
                foreach (MedicalCard card in cards) {
                    if ((card.age >= ageFrom || ageFrom == 0) && (card.age <= ageTo || ageTo == 0)) {
                        result.Add(card);
                    }
                }
            }

            return result;
        }

        public static bool IsBetween(DateTime between, DateTime p1, DateTime dt2) {
            return between.DayOfYear >= p1.DayOfYear && between.DayOfYear <= dt2.DayOfYear;
        }
    }
}
