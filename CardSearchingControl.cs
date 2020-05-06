using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs15.models;

namespace Kurs15 {
    public partial class CardSearchingControl : UserControl {
        public CardSearchingControl() {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox1 = (CheckBox)sender;
            DateTimePicker dateTimePicker1 = (DateTimePicker)Controls.Find("dateTimePicker1", true)[0];
            dateTimePicker1.Enabled = checkBox1.Checked;
        }

        private void checkBoxAge_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBoxAge = (CheckBox)sender;
            NumericUpDown ageFrom = (NumericUpDown)Controls.Find("ageFrom", true)[0];
            NumericUpDown ageTo = (NumericUpDown)Controls.Find("ageTo", true)[0];

            ageFrom.Enabled = checkBoxAge.Checked;
            ageTo.Enabled = checkBoxAge.Checked;
        }

        List<MedicalCard> result = new List<MedicalCard>();

        private void searchButton_Click(object sender, EventArgs e) {
            TextBox nameTB = (TextBox)Controls.Find("nameTB", true)[0];
            TextBox surnameTB = (TextBox)Controls.Find("surnameTB", true)[0];
            TextBox patronymicTB = (TextBox)Controls.Find("patronymicTB", true)[0];

            result = ClinicalHospital.GetCardsByPIB(Program.clinicalHospital.medicalCards, nameTB.Text, surnameTB.Text, patronymicTB.Text);

            DateTimePicker dateTimePicker1 = (DateTimePicker)Controls.Find("dateTimePicker1", true)[0];
            CheckBox checkBox1 = (CheckBox)Controls.Find("checkBox1", true)[0];
            if (checkBox1.Checked) {
                result = ClinicalHospital.GetCardsByDate(result, dateTimePicker1.Value, checkBox1.Checked);
            }

            ComboBox extractedCB = (ComboBox)Controls.Find("extractedCB", true)[0];
            if (!extractedCB.SelectedItem.Equals("")) {
                if (extractedCB.SelectedItem.Equals("Виписані")) {
                    result = ClinicalHospital.GetCardsExtracted(result);
                }

                if (extractedCB.SelectedItem.Equals("Не виписані")) {
                    result = ClinicalHospital.GetCardsNotExtracted(result);
                }
            }

            CheckBox checkBoxAge = (CheckBox)Controls.Find("checkBoxAge", true)[0];
            NumericUpDown ageFrom = (NumericUpDown)Controls.Find("ageFrom", true)[0];
            NumericUpDown ageTo = (NumericUpDown)Controls.Find("ageTo", true)[0];
            if (checkBoxAge.Checked) {
                result = ClinicalHospital.GetCardsByAge(result, (int)ageFrom.Value, (int)ageTo.Value, checkBoxAge.Checked);
            }

            CardsList cardsList = (CardsList)Controls.Find("cardsList1", true)[0];
            cardsList.UpdateControl(result);
        }
    }
}
