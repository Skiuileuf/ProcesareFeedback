﻿namespace ProcesareFeedback
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.destinationFolderBrowseButton = new System.Windows.Forms.Button();
            this.destinationFolderPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.templateBrowseButton = new System.Windows.Forms.Button();
            this.templatePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.documentWorker = new System.ComponentModel.BackgroundWorker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.progressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel Spreadsheet|*.xlsx";
            this.openFileDialog.Title = "Alege fisierul descarcat din Google Forms";
            // 
            // nclasa
            // 
            this.nclasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nclasa.Location = new System.Drawing.Point(119, 133);
            this.nclasa.Name = "nclasa";
            this.nclasa.Size = new System.Drawing.Size(457, 20);
            this.nclasa.TabIndex = 0;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chooseFileButton.Location = new System.Drawing.Point(313, 269);
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
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N Clasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "L Clasa:";
            // 
            // lclasa
            // 
            this.lclasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lclasa.Location = new System.Drawing.Point(119, 159);
            this.lclasa.Name = "lclasa";
            this.lclasa.Size = new System.Drawing.Size(457, 20);
            this.lclasa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "An Scolar:";
            // 
            // anscolar
            // 
            this.anscolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anscolar.Location = new System.Drawing.Point(119, 185);
            this.anscolar.Name = "anscolar";
            this.anscolar.Size = new System.Drawing.Size(457, 20);
            this.anscolar.TabIndex = 5;
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.Location = new System.Drawing.Point(6, 271);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(301, 20);
            this.pathBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diriginte:";
            // 
            // diriginte
            // 
            this.diriginte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diriginte.Location = new System.Drawing.Point(119, 263);
            this.diriginte.Name = "diriginte";
            this.diriginte.Size = new System.Drawing.Size(457, 20);
            this.diriginte.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nr Elevi:";
            // 
            // nrelevi
            // 
            this.nrelevi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nrelevi.Location = new System.Drawing.Point(119, 237);
            this.nrelevi.Name = "nrelevi";
            this.nrelevi.Size = new System.Drawing.Size(457, 20);
            this.nrelevi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Semestru:";
            // 
            // semestru
            // 
            this.semestru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.semestru.Location = new System.Drawing.Point(119, 211);
            this.semestru.Name = "semestru";
            this.semestru.Size = new System.Drawing.Size(457, 20);
            this.semestru.TabIndex = 12;
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.generateButton.Location = new System.Drawing.Point(313, 97);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Genereaza";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chooseFileButton);
            this.groupBox1.Controls.Add(this.pathBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 298);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Incarcare";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Majoritatea elevilor au fost prezenti la % ore";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "In medie fiecare elev a acordat feedback catre N profesori";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Se vor genera N rapoarte";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adauga aici fisierul .xlsx descarcat din Google Forms!\r\nApasa pe \"Selecteaza...\"\r" +
    "\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nclasa);
            this.groupBox2.Controls.Add(this.lclasa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.semestru);
            this.groupBox2.Controls.Add(this.anscolar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.diriginte);
            this.groupBox2.Controls.Add(this.nrelevi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(409, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 298);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Parametri";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(577, 104);
            this.label8.TabIndex = 12;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.destinationFolderBrowseButton);
            this.groupBox3.Controls.Add(this.destinationFolderPath);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.templateBrowseButton);
            this.groupBox3.Controls.Add(this.templatePath);
            this.groupBox3.Controls.Add(this.generateButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 196);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Generare";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Genereaza un singur raport";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Folder destinatie";
            // 
            // destinationFolderBrowseButton
            // 
            this.destinationFolderBrowseButton.Location = new System.Drawing.Point(313, 71);
            this.destinationFolderBrowseButton.Name = "destinationFolderBrowseButton";
            this.destinationFolderBrowseButton.Size = new System.Drawing.Size(75, 22);
            this.destinationFolderBrowseButton.TabIndex = 19;
            this.destinationFolderBrowseButton.Text = "Selecteaza...";
            this.destinationFolderBrowseButton.UseVisualStyleBackColor = true;
            // 
            // destinationFolderPath
            // 
            this.destinationFolderPath.Location = new System.Drawing.Point(6, 71);
            this.destinationFolderPath.Name = "destinationFolderPath";
            this.destinationFolderPath.ReadOnly = true;
            this.destinationFolderPath.Size = new System.Drawing.Size(301, 20);
            this.destinationFolderPath.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Model";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(403, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(570, 177);
            this.label9.TabIndex = 17;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // templateBrowseButton
            // 
            this.templateBrowseButton.Location = new System.Drawing.Point(313, 30);
            this.templateBrowseButton.Name = "templateBrowseButton";
            this.templateBrowseButton.Size = new System.Drawing.Size(75, 22);
            this.templateBrowseButton.TabIndex = 15;
            this.templateBrowseButton.Text = "Selecteaza...";
            this.templateBrowseButton.UseVisualStyleBackColor = true;
            // 
            // templatePath
            // 
            this.templatePath.Location = new System.Drawing.Point(6, 32);
            this.templatePath.Name = "templatePath";
            this.templatePath.ReadOnly = true;
            this.templatePath.Size = new System.Drawing.Size(301, 20);
            this.templatePath.TabIndex = 16;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.Recent;
            // 
            // progressGroupBox
            // 
            this.progressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressGroupBox.Controls.Add(this.progressBar);
            this.progressGroupBox.Location = new System.Drawing.Point(12, 1);
            this.progressGroupBox.Name = "progressGroupBox";
            this.progressGroupBox.Size = new System.Drawing.Size(980, 42);
            this.progressGroupBox.TabIndex = 18;
            this.progressGroupBox.TabStop = false;
            this.progressGroupBox.Text = "Progres";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 16);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(974, 23);
            this.progressBar.TabIndex = 0;
            // 
            // documentWorker
            // 
            this.documentWorker.WorkerReportsProgress = true;
            this.documentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.documentWorker_DoWork);
            this.documentWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.documentWorker_ProgressChanged);
            this.documentWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.documentWorker_RunWorkerCompleted);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.progressGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "MainForm";
            this.Text = "ProcesareFeedback";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.progressGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button templateBrowseButton;
        private System.Windows.Forms.TextBox templatePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button destinationFolderBrowseButton;
        private System.Windows.Forms.TextBox destinationFolderPath;
        private System.Windows.Forms.GroupBox progressGroupBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker documentWorker;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

