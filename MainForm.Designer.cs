namespace Kurs15 {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.extractBtn = new System.Windows.Forms.Button();
            this.chamberN = new System.Windows.Forms.NumericUpDown();
            this.setChamberBtn = new System.Windows.Forms.Button();
            this.cardSearchingControl1 = new Kurs15.CardSearchingControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chamberListControl1 = new Kurs15.ChamberListControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реєстраціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerChamberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chamberN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.extractBtn);
            this.groupBox2.Controls.Add(this.chamberN);
            this.groupBox2.Controls.Add(this.setChamberBtn);
            this.groupBox2.Controls.Add(this.cardSearchingControl1);
            this.groupBox2.Location = new System.Drawing.Point(3, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 420);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук медичної карти";
            // 
            // extractBtn
            // 
            this.extractBtn.Location = new System.Drawing.Point(421, 202);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(75, 23);
            this.extractBtn.TabIndex = 3;
            this.extractBtn.Text = "Виписати";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // chamberN
            // 
            this.chamberN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chamberN.Location = new System.Drawing.Point(98, 205);
            this.chamberN.Name = "chamberN";
            this.chamberN.Size = new System.Drawing.Size(51, 20);
            this.chamberN.TabIndex = 2;
            // 
            // setChamberBtn
            // 
            this.setChamberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.setChamberBtn.Location = new System.Drawing.Point(9, 202);
            this.setChamberBtn.Name = "setChamberBtn";
            this.setChamberBtn.Size = new System.Drawing.Size(83, 23);
            this.setChamberBtn.TabIndex = 1;
            this.setChamberBtn.Text = "Перевести в";
            this.setChamberBtn.UseVisualStyleBackColor = false;
            this.setChamberBtn.Click += new System.EventHandler(this.setChamberBtn_Click);
            // 
            // cardSearchingControl1
            // 
            this.cardSearchingControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearchingControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSearchingControl1.Location = new System.Drawing.Point(6, 19);
            this.cardSearchingControl1.Name = "cardSearchingControl1";
            this.cardSearchingControl1.Size = new System.Drawing.Size(493, 392);
            this.cardSearchingControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.chamberListControl1);
            this.groupBox1.Location = new System.Drawing.Point(508, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список палат";
            // 
            // chamberListControl1
            // 
            this.chamberListControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chamberListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chamberListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chamberListControl1.Location = new System.Drawing.Point(3, 16);
            this.chamberListControl1.Name = "chamberListControl1";
            this.chamberListControl1.Size = new System.Drawing.Size(194, 401);
            this.chamberListControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реєстраціяToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реєстраціяToolStripMenuItem
            // 
            this.реєстраціяToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.реєстраціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerChamberToolStripMenuItem,
            this.registerCardToolStripMenuItem});
            this.реєстраціяToolStripMenuItem.Name = "реєстраціяToolStripMenuItem";
            this.реєстраціяToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.реєстраціяToolStripMenuItem.Text = "Реєстрація";
            this.реєстраціяToolStripMenuItem.Click += new System.EventHandler(this.реєстраціяToolStripMenuItem_Click);
            // 
            // registerChamberToolStripMenuItem
            // 
            this.registerChamberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerChamberToolStripMenuItem.Name = "registerChamberToolStripMenuItem";
            this.registerChamberToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registerChamberToolStripMenuItem.Text = "Реєстрація палати";
            this.registerChamberToolStripMenuItem.Click += new System.EventHandler(this.registerChamberToolStripMenuItem_Click);
            // 
            // registerCardToolStripMenuItem
            // 
            this.registerCardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerCardToolStripMenuItem.Name = "registerCardToolStripMenuItem";
            this.registerCardToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registerCardToolStripMenuItem.Text = "Реєстрація медичної карти";
            this.registerCardToolStripMenuItem.Click += new System.EventHandler(this.registerCardToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.refreshToolStripMenuItem.Text = "Оновити";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chamberN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ChamberListControl chamberListControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реєстраціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerChamberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCardToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private CardSearchingControl cardSearchingControl1;
        private System.Windows.Forms.Button setChamberBtn;
        private System.Windows.Forms.NumericUpDown chamberN;
        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}