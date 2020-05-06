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
    public partial class RegisterChamberForm : Form {
        public RegisterChamberForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            NumericUpDown numberN = (NumericUpDown)Controls.Find("numberN", true)[0];
            TextBox numberTelTB = (TextBox)Controls.Find("numberTelTB", true)[0];

            Chamber chamber = new Chamber((int) numberN.Value, numberTelTB.Text, DateTime.Now);

            if(Program.clinicalHospital.RegisterChamber(chamber)) {
                MessageBox.Show("Палата зареєстрована");
                Close();
            } else {
                chamber = null;
                MessageBox.Show("Помилка реєстрації палати! Спробуйте ще раз");
            }
        }
    }
}
