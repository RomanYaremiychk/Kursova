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
    public partial class ChamberListControl : UserControl {

        ChamberForm chamberForm;

        public ChamberListControl() {
            InitializeComponent();
            chamberForm = new ChamberForm();
        }

        public void UpdateControl(List<Chamber> chambers) {
            ListBox chamberList = (ListBox)Controls.Find("chamberList", true)[0];
            chamberList.DataSource = null;
            chamberList.DataSource = chambers;
        }

        private void chamberList_DoubleClick(object sender, EventArgs e) {
            ListBox chamberList = (ListBox)Controls.Find("chamberList", true)[0];

            Chamber selectedChamber = (Chamber) chamberList.SelectedItem;
            chamberForm.UpdateForm(selectedChamber);
            chamberForm.ShowDialog();
            
        }
    }
}
