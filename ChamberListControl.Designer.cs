namespace Kurs15 {
    partial class ChamberListControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chamberList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chamberList
            // 
            this.chamberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chamberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chamberList.FormattingEnabled = true;
            this.chamberList.Location = new System.Drawing.Point(0, 0);
            this.chamberList.Name = "chamberList";
            this.chamberList.Size = new System.Drawing.Size(200, 177);
            this.chamberList.TabIndex = 0;
            this.chamberList.DoubleClick += new System.EventHandler(this.chamberList_DoubleClick);
            // 
            // ChamberListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chamberList);
            this.Name = "ChamberListControl";
            this.Size = new System.Drawing.Size(200, 177);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox chamberList;
    }
}
