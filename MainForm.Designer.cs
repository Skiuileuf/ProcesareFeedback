namespace ProcesareFeedback
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nclasa = new System.Windows.Forms.TextBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lclasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.anscolar = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.diriginte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nrelevi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.semestru = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel Spreadsheet|*.xlsx";
            this.openFileDialog.Title = "Alege fisierul descarcat din Google Forms";
            // 
            // nclasa
            // 
            this.nclasa.Location = new System.Drawing.Point(125, 6);
            this.nclasa.Name = "nclasa";
            this.nclasa.Size = new System.Drawing.Size(157, 20);
            this.nclasa.TabIndex = 0;
            this.nclasa.Text = "V";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(713, 415);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Selecteaza...";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N Clasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "L Clasa:";
            // 
            // lclasa
            // 
            this.lclasa.Location = new System.Drawing.Point(125, 32);
            this.lclasa.Name = "lclasa";
            this.lclasa.Size = new System.Drawing.Size(157, 20);
            this.lclasa.TabIndex = 3;
            this.lclasa.Text = "J";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "An Scolar:";
            // 
            // anscolar
            // 
            this.anscolar.Location = new System.Drawing.Point(125, 58);
            this.anscolar.Name = "anscolar";
            this.anscolar.Size = new System.Drawing.Size(157, 20);
            this.anscolar.TabIndex = 5;
            this.anscolar.Text = "2021-2022";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 417);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(695, 20);
            this.pathBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diriginte:";
            // 
            // diriginte
            // 
            this.diriginte.Location = new System.Drawing.Point(125, 136);
            this.diriginte.Name = "diriginte";
            this.diriginte.Size = new System.Drawing.Size(157, 20);
            this.diriginte.TabIndex = 9;
            this.diriginte.Text = "numeprof";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nr Elevi:";
            // 
            // nrelevi
            // 
            this.nrelevi.Location = new System.Drawing.Point(125, 110);
            this.nrelevi.Name = "nrelevi";
            this.nrelevi.Size = new System.Drawing.Size(157, 20);
            this.nrelevi.TabIndex = 7;
            this.nrelevi.Text = "29";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Semestru:";
            // 
            // semestru
            // 
            this.semestru.Location = new System.Drawing.Point(125, 84);
            this.semestru.Name = "semestru";
            this.semestru.Size = new System.Drawing.Size(157, 20);
            this.semestru.TabIndex = 12;
            this.semestru.Text = "I";
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Location = new System.Drawing.Point(15, 172);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(267, 75);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Genereaza";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.semestru);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diriginte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nrelevi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anscolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lclasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.nclasa);
            this.Name = "MainForm";
            this.Text = "ProcesareFeedback";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox nclasa;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lclasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anscolar;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diriginte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nrelevi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox semestru;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

