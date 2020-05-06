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
using Newtonsoft.Json;

namespace Kurs15 {
    public partial class MainForm : Form {

        RegisterChamberForm registerChamberForm;
        RegisterCardForm registerCardForm;
        RegisterExtractForm registerExtractForm;

        public MainForm() {
            InitializeComponent();
            registerChamberForm = new RegisterChamberForm();
            registerCardForm = new RegisterCardForm();
            registerExtractForm = new RegisterExtractForm();
        }

        public void UpdateForm() {
            ChamberListControl chamberListControl1 = (ChamberListControl)Controls.Find("chamberListControl1", true)[0];
            chamberListControl1.UpdateControl(Program.clinicalHospital.chambers);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateForm();
        }

        private void registerChamberToolStripMenuItem_Click(object sender, EventArgs e) {
            registerChamberForm.ShowDialog();
        }

        private void registerCardToolStripMenuItem_Click(object sender, EventArgs e) {
            registerCardForm.ShowDialog();
        }

        private void setChamberBtn_Click(object sender, EventArgs e) {
            CardSearchingControl cardSearchingControl1 = (CardSearchingControl)Controls.Find("cardSearchingControl1", true)[0];
            CardsList cardsList = (CardsList)cardSearchingControl1.Controls.Find("cardsList1", true)[0];
            ListBox listBox1 = (ListBox)cardsList.Controls.Find("listBox1", true)[0];
            NumericUpDown chamberN = (NumericUpDown)Controls.Find("chamberN", true)[0];

            MedicalCard medicalCard = (MedicalCard)listBox1.SelectedItem;

            Chamber chamber_g = Program.clinicalHospital.GetChamber((int)chamberN.Value);
            Chamber chamber = null;

            if(chamber_g != null) {
                chamber = new Chamber(chamber_g.number, chamber_g.numberTel, DateTime.Now);
                medicalCard.SetChamber(chamber);
                MessageBox.Show("Пацієнт був переведений");
            } else {
                MessageBox.Show("Пацієнт не переведений! Спробуйте ще раз");
            }
        }

        private void extractBtn_Click(object sender, EventArgs e) {
            CardSearchingControl cardSearchingControl1 = (CardSearchingControl)Controls.Find("cardSearchingControl1", true)[0];
            CardsList cardsList = (CardsList)cardSearchingControl1.Controls.Find("cardsList1", true)[0];
            ListBox listBox1 = (ListBox)cardsList.Controls.Find("listBox1", true)[0];
            NumericUpDown chamberN = (NumericUpDown)Controls.Find("chamberN", true)[0];

            MedicalCard medicalCard = (MedicalCard)listBox1.SelectedItem;

            if (medicalCard.extract == null) {
                registerExtractForm.UpdateForm(medicalCard);
                registerExtractForm.ShowDialog();
            } else {
                MessageBox.Show("Пацієнт вже виписаний");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                System.IO.File.WriteAllText(openFileDialog.FileName, JsonConvert.SerializeObject(Program.clinicalHospital, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void реєстраціяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
