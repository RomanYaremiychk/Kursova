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
    public partial class ChamberForm : Form {
        public ChamberForm() {
            InitializeComponent();
        }

        public void UpdateForm(Chamber chamber, bool card = false) {
            Label numberL = (Label)Controls.Find("numberL", true)[0];
            Label numberTelL = (Label)Controls.Find("numberTelL", true)[0];
            Label dateEntryL = (Label)Controls.Find("dateEntryL", true)[0];

            Label DateLabel = (Label)Controls.Find("DateLabel", true)[0];

            if(card) {
                DateLabel.Text = "Дата переведення";
            } else {
                DateLabel.Text = "Дата створення";
            }

            numberL.Text = "" + chamber.number;
            numberTelL.Text = chamber.numberTel;
            dateEntryL.Text = chamber.dateEntry.ToString();
        }
    }
}
