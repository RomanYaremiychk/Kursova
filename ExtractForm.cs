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
    public partial class ExtractForm : Form {

        private MedicalCard current;
        CardForm cardForm = new CardForm();

        public ExtractForm() {
            InitializeComponent();
        }

        public void UpdateForm(MedicalCard medicalCard) {
            current = medicalCard;
            Label dateExtract = (Label)Controls.Find("dateExtract", true)[0];
            TextBox reasonTB = (TextBox)Controls.Find("reasonTB", true)[0];
            if (medicalCard.extract != null) {
                dateExtract.Text = medicalCard.extract.dateExtract.ToString();
                reasonTB.Text = medicalCard.extract.reason;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            cardForm.UpdateForm(current);
            cardForm.ShowDialog();
        }
    }
}
