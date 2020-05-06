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
    public partial class CardsList : UserControl {

        CardForm cardForm;

        public CardsList() {
            InitializeComponent();
            cardForm = new CardForm();
        }

        public void UpdateControl(List<MedicalCard> medicalCards) {
            ListBox listBox1 = (ListBox)Controls.Find("listBox1", true)[0];
            listBox1.DataSource = null;
            listBox1.DataSource = medicalCards;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            ListBox listBox = (ListBox)sender;

            cardForm.UpdateForm((MedicalCard)listBox.SelectedItem);
            cardForm.ShowDialog();
        }
    }
}
