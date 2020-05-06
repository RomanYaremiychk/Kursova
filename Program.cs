using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs15.models;
using Newtonsoft.Json;

namespace Kurs15 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static ClinicalHospital clinicalHospital;
        public static MainForm mainForm;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                clinicalHospital = JsonConvert.DeserializeObject<ClinicalHospital>(System.IO.File.ReadAllText(openFileDialog.FileName));
            } else {
                clinicalHospital = new ClinicalHospital();
            }

            mainForm = new MainForm();

            Application.Run(mainForm);
        }
    }
}
