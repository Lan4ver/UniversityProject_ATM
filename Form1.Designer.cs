namespace MaksymPodorozhnyi_50402_ProjektNr1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoneyToGet = new System.Windows.Forms.TextBox();
            this.txtMoneyGet = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKoniec = new System.Windows.Forms.Button();
            this.rdbStandart = new System.Windows.Forms.RadioButton();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.cmbWalut = new System.Windows.Forms.ComboBox();
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.NumberOfBanknots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominalOfBanknot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajWaluty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bankomat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wypłacane nominaly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wybierz rodzaj waluty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(809, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Wypłaczana kwota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(809, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Podaj wysokość \r\nkłoty do wypłaty";
            // 
            // txtMoneyToGet
            // 
            this.txtMoneyToGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoneyToGet.Location = new System.Drawing.Point(822, 121);
            this.txtMoneyToGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoneyToGet.Name = "txtMoneyToGet";
            this.txtMoneyToGet.Size = new System.Drawing.Size(135, 26);
            this.txtMoneyToGet.TabIndex = 10;
            // 
            // txtMoneyGet
            // 
            this.txtMoneyGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoneyGet.Location = new System.Drawing.Point(808, 385);
            this.txtMoneyGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoneyGet.Name = "txtMoneyGet";
            this.txtMoneyGet.ReadOnly = true;
            this.txtMoneyGet.Size = new System.Drawing.Size(144, 26);
            this.txtMoneyGet.TabIndex = 11;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(822, 154);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(135, 34);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Akceptacja";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(808, 417);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 30);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Resetuj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKoniec
            // 
            this.btnKoniec.Location = new System.Drawing.Point(808, 454);
            this.btnKoniec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKoniec.Name = "btnKoniec";
            this.btnKoniec.Size = new System.Drawing.Size(144, 30);
            this.btnKoniec.TabIndex = 14;
            this.btnKoniec.Text = "Koniec";
            this.btnKoniec.UseVisualStyleBackColor = true;
            this.btnKoniec.Click += new System.EventHandler(this.btnKoniec_Click);
            // 
            // rdbStandart
            // 
            this.rdbStandart.AutoSize = true;
            this.rdbStandart.Checked = true;
            this.rdbStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbStandart.Location = new System.Drawing.Point(144, 196);
            this.rdbStandart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbStandart.Name = "rdbStandart";
            this.rdbStandart.Size = new System.Drawing.Size(269, 24);
            this.rdbStandart.TabIndex = 15;
            this.rdbStandart.TabStop = true;
            this.rdbStandart.Text = "Liczność wystawiana domyślnie";
            this.rdbStandart.UseVisualStyleBackColor = true;
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbCustom.Location = new System.Drawing.Point(419, 197);
            this.rdbCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(335, 24);
            this.rdbCustom.TabIndex = 16;
            this.rdbCustom.Text = "Liczność ustawiana losowo przez klienta";
            this.rdbCustom.UseVisualStyleBackColor = true;
            this.rdbCustom.CheckedChanged += new System.EventHandler(this.rdbCustom_CheckedChanged);
            // 
            // cmbWalut
            // 
            this.cmbWalut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbWalut.FormattingEnabled = true;
            this.cmbWalut.Items.AddRange(new object[] {
            "PLN",
            "Szekel",
            "Drewniany"});
            this.cmbWalut.Location = new System.Drawing.Point(12, 133);
            this.cmbWalut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWalut.Name = "cmbWalut";
            this.cmbWalut.Size = new System.Drawing.Size(192, 28);
            this.cmbWalut.TabIndex = 17;
            this.cmbWalut.Text = "Lista walut";
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfBanknots,
            this.NominalOfBanknot,
            this.TypeOfMoney,
            this.RodzajWaluty});
            this.dgvPaymentList.Location = new System.Drawing.Point(15, 347);
            this.dgvPaymentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.RowHeadersWidth = 51;
            this.dgvPaymentList.RowTemplate.Height = 24;
            this.dgvPaymentList.Size = new System.Drawing.Size(765, 150);
            this.dgvPaymentList.TabIndex = 18;
            // 
            // NumberOfBanknots
            // 
            this.NumberOfBanknots.HeaderText = "Liczba Nominalów";
            this.NumberOfBanknots.MinimumWidth = 6;
            this.NumberOfBanknots.Name = "NumberOfBanknots";
            this.NumberOfBanknots.Width = 125;
            // 
            // NominalOfBanknot
            // 
            this.NominalOfBanknot.HeaderText = "Wartość nominalu";
            this.NominalOfBanknot.MinimumWidth = 6;
            this.NominalOfBanknot.Name = "NominalOfBanknot";
            this.NominalOfBanknot.Width = 125;
            // 
            // TypeOfMoney
            // 
            this.TypeOfMoney.HeaderText = "Rodzaj nominalu";
            this.TypeOfMoney.MinimumWidth = 6;
            this.TypeOfMoney.Name = "TypeOfMoney";
            this.TypeOfMoney.Width = 125;
            // 
            // RodzajWaluty
            // 
            this.RodzajWaluty.HeaderText = "Rodzaj waluty";
            this.RodzajWaluty.MinimumWidth = 6;
            this.RodzajWaluty.Name = "RodzajWaluty";
            this.RodzajWaluty.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMax.Location = new System.Drawing.Point(392, 261);
            this.txtMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(135, 26);
            this.txtMax.TabIndex = 20;
            this.txtMax.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(388, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Maksymalny banknot";
            this.label5.Visible = false;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMin.Location = new System.Drawing.Point(628, 261);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(135, 26);
            this.txtMin.TabIndex = 22;
            this.txtMin.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(624, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Minimalny banknot";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 529);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPaymentList);
            this.Controls.Add(this.cmbWalut);
            this.Controls.Add(this.rdbCustom);
            this.Controls.Add(this.rdbStandart);
            this.Controls.Add(this.btnKoniec);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtMoneyGet);
            this.Controls.Add(this.txtMoneyToGet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoneyToGet;
        private System.Windows.Forms.TextBox txtMoneyGet;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKoniec;
        private System.Windows.Forms.RadioButton rdbStandart;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.ComboBox cmbWalut;
        private System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfBanknots;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominalOfBanknot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajWaluty;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label5;
    }
}

