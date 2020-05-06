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
    public partial class RegisterExtractForm : Form {

        private MedicalCard current;
        CardForm cardForm;

        public RegisterExtractForm() {
            InitializeComponent();
            cardForm = new CardForm();
        }

        public void UpdateForm(MedicalCard medicalCard) {
            current = medicalCard;

        }

        private void button1_Click(object sender, EventArgs e) {
            cardForm.UpdateForm(current);
            cardForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            TextBox reasonTB = (TextBox)Controls.Find("reasonTB", true)[0];
            current.extract = new Extract(current, DateTime.Now, reasonTB.Text);
            MessageBox.Show("Пацієнт виписаний");
            Close();
        }
    }
}
