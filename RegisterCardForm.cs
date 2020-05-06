using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs15.models;

namespace Kurs15 {
    public partial class RegisterCardForm : Form {
        public RegisterCardForm() {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            TextBox nameTB = (TextBox)Controls.Find("nameTB", true)[0];
            TextBox surnameTB = (TextBox)Controls.Find("surnameTB", true)[0];
            TextBox patronymicTB = (TextBox)Controls.Find("patronymicTB", true)[0];
            NumericUpDown ageN = (NumericUpDown)Controls.Find("ageN", true)[0];
            DateTimePicker dateEntry = (DateTimePicker)Controls.Find("dateEntry", true)[0];
            TextBox directionTB = (TextBox)Controls.Find("directionTB", true)[0];
            TextBox additionalDescTB = (TextBox)Controls.Find("additionalDescTB", true)[0];
            NumericUpDown chamberN = (NumericUpDown)Controls.Find("chamberN", true)[0];

            MedicalCard medicalCard = new MedicalCard();
            medicalCard.name = nameTB.Text;
            medicalCard.surname = surnameTB.Text;
            medicalCard.patronymic = patronymicTB.Text;
            medicalCard.age = (int)ageN.Value;
            medicalCard.dateEntry = dateEntry.Value;
            medicalCard.direction = directionTB.Text;
            medicalCard.additionalDescription = additionalDescTB.Text;

            Chamber chamber_g = Program.clinicalHospital.GetChamber((int) chamberN.Value);
            Chamber chamber = null;
            if(chamber_g != null) {
                chamber = new Chamber(chamber_g.number, chamber_g.numberTel, dateEntry.Value);
                medicalCard.SetChamber(chamber);
            }

            if (Program.clinicalHospital.RegisterMedicalCard(medicalCard)) {
                MessageBox.Show("Медична карта зареєстрована");
            } else {
                medicalCard = null;
                MessageBox.Show("Помилка в реєстрації медичної карти! Спробуйте ще раз");
            }
        }
    }
}
