using Kurs15.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs15 {
    public partial class CardForm : Form {

        private MedicalCard current = null;

        public CardForm() {
            InitializeComponent();
        }

        public void UpdateForm(MedicalCard medicalCard) {
            current = medicalCard;
            Label nameL = (Label)Controls.Find("nameL", true)[0];
            Label surnameL = (Label)Controls.Find("surnameL", true)[0];
            Label patronymicL = (Label)Controls.Find("patronymicL", true)[0];
            Label ageL = (Label)Controls.Find("ageL", true)[0];
            Label dateEntryL = (Label)Controls.Find("dateEntryL", true)[0];
            TextBox directionTB = (TextBox)Controls.Find("directionTB", true)[0];
            TextBox additionalDescTB = (TextBox)Controls.Find("additionalDescTB", true)[0];

            nameL.Text = medicalCard.name;
            surnameL.Text = medicalCard.surname;
            patronymicL.Text = medicalCard.patronymic;
            ageL.Text = "" + medicalCard.age;
            dateEntryL.Text = medicalCard.dateEntry.ToString();
            directionTB.Text = medicalCard.direction;
            additionalDescTB.Text = medicalCard.additionalDescription;
        }

        private void button2_Click(object sender, EventArgs e) {
            Form form = new Form();
            ChamberListControl chamberListControl = new ChamberListControl();
            form.Controls.Add(chamberListControl);
            chamberListControl.UpdateControl(current.chambers);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (current != null && current.extract != null) {
                ExtractForm extractForm = new ExtractForm();
                extractForm.UpdateForm(current);
                extractForm.ShowDialog();
            } else {
                MessageBox.Show("Пацієнт не виписаний!");
            }
        }
    }
}
