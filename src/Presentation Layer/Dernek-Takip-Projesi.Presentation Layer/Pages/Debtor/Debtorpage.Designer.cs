using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Debtor
{
    partial class Debtorpage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addIsDebtorCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.addRevenueIdComboBox = new System.Windows.Forms.ComboBox();
            this.addMemberIdComboBox = new System.Windows.Forms.ComboBox();
            this.getAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateRevenueIdComboBox = new System.Windows.Forms.ComboBox();
            this.updateIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateMemberIdComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateIsDebtorCheckBox = new System.Windows.Forms.CheckBox();
            this.exportPdfButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listRevenueIdcomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.listMemberIdcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listIsDebtorcheckBox = new System.Windows.Forms.CheckBox();
            this.addIdtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIDAT NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "TCKN NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ODEDI MI:";
            // 
            // addIsDebtorCheckBox
            // 
            this.addIsDebtorCheckBox.AutoSize = true;
            this.addIsDebtorCheckBox.Location = new System.Drawing.Point(130, 182);
            this.addIsDebtorCheckBox.Name = "addIsDebtorCheckBox";
            this.addIsDebtorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.addIsDebtorCheckBox.TabIndex = 1;
            this.addIsDebtorCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1246, 284);
            this.dataGridView1.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(295, 54);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "EKLE";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addRevenueIdComboBox
            // 
            this.addRevenueIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addRevenueIdComboBox.FormattingEnabled = true;
            this.addRevenueIdComboBox.Location = new System.Drawing.Point(130, 80);
            this.addRevenueIdComboBox.Name = "addRevenueIdComboBox";
            this.addRevenueIdComboBox.Size = new System.Drawing.Size(171, 28);
            this.addRevenueIdComboBox.TabIndex = 5;
            // 
            // addMemberIdComboBox
            // 
            this.addMemberIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMemberIdComboBox.FormattingEnabled = true;
            this.addMemberIdComboBox.Location = new System.Drawing.Point(130, 131);
            this.addMemberIdComboBox.Name = "addMemberIdComboBox";
            this.addMemberIdComboBox.Size = new System.Drawing.Size(171, 28);
            this.addMemberIdComboBox.TabIndex = 5;
            // 
            // getAllButton
            // 
            this.getAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllButton.Location = new System.Drawing.Point(334, 302);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(141, 291);
            this.getAllButton.TabIndex = 6;
            this.getAllButton.Text = "HEPSİNİ GETİR";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.addIdtextBox);
            this.groupBox1.Controls.Add(this.addRevenueIdComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.addMemberIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addIsDebtorCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 291);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BORÇLU EKLEME";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.updateRevenueIdComboBox);
            this.groupBox2.Controls.Add(this.updateIdTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.updateMemberIdComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.updateIsDebtorCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(481, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 293);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BORÇLU GÜNCELLEME";
            // 
            // updateRevenueIdComboBox
            // 
            this.updateRevenueIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateRevenueIdComboBox.FormattingEnabled = true;
            this.updateRevenueIdComboBox.Location = new System.Drawing.Point(146, 69);
            this.updateRevenueIdComboBox.Name = "updateRevenueIdComboBox";
            this.updateRevenueIdComboBox.Size = new System.Drawing.Size(155, 28);
            this.updateRevenueIdComboBox.TabIndex = 5;
            // 
            // updateIdTextBox
            // 
            this.updateIdTextBox.Location = new System.Drawing.Point(146, 25);
            this.updateIdTextBox.MaxLength = 9;
            this.updateIdTextBox.Name = "updateIdTextBox";
            this.updateIdTextBox.Size = new System.Drawing.Size(155, 26);
            this.updateIdTextBox.TabIndex = 9;
            this.updateIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateIdTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "AIDAT NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID No:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 220);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(295, 54);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "GÜNCELLE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateMemberIdComboBox
            // 
            this.updateMemberIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateMemberIdComboBox.FormattingEnabled = true;
            this.updateMemberIdComboBox.Location = new System.Drawing.Point(146, 115);
            this.updateMemberIdComboBox.Name = "updateMemberIdComboBox";
            this.updateMemberIdComboBox.Size = new System.Drawing.Size(155, 28);
            this.updateMemberIdComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ODEDI MI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "TCKN NO:";
            // 
            // updateIsDebtorCheckBox
            // 
            this.updateIsDebtorCheckBox.AutoSize = true;
            this.updateIsDebtorCheckBox.Location = new System.Drawing.Point(146, 169);
            this.updateIsDebtorCheckBox.Name = "updateIsDebtorCheckBox";
            this.updateIsDebtorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.updateIsDebtorCheckBox.TabIndex = 1;
            this.updateIsDebtorCheckBox.UseVisualStyleBackColor = true;
            // 
            // exportPdfButton
            // 
            this.exportPdfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.exportPdfButton.Location = new System.Drawing.Point(794, 302);
            this.exportPdfButton.Name = "exportPdfButton";
            this.exportPdfButton.Size = new System.Drawing.Size(141, 291);
            this.exportPdfButton.TabIndex = 9;
            this.exportPdfButton.Text = "PDF AKTAR";
            this.exportPdfButton.UseVisualStyleBackColor = true;
            this.exportPdfButton.Click += new System.EventHandler(this.exportPdfButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.listRevenueIdcomboBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listButton);
            this.groupBox3.Controls.Add(this.listMemberIdcomboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.listIsDebtorcheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(941, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 293);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BORÇLU LİSTELEME";
            // 
            // listRevenueIdcomboBox
            // 
            this.listRevenueIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRevenueIdcomboBox.FormattingEnabled = true;
            this.listRevenueIdcomboBox.Location = new System.Drawing.Point(137, 31);
            this.listRevenueIdcomboBox.Name = "listRevenueIdcomboBox";
            this.listRevenueIdcomboBox.Size = new System.Drawing.Size(155, 28);
            this.listRevenueIdcomboBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "AIDAT NO:";
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(6, 220);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(295, 54);
            this.listButton.TabIndex = 4;
            this.listButton.Text = "LİSTELE";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // listMemberIdcomboBox
            // 
            this.listMemberIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMemberIdcomboBox.FormattingEnabled = true;
            this.listMemberIdcomboBox.Location = new System.Drawing.Point(137, 77);
            this.listMemberIdcomboBox.Name = "listMemberIdcomboBox";
            this.listMemberIdcomboBox.Size = new System.Drawing.Size(155, 28);
            this.listMemberIdcomboBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "ODEDI MI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "TCKN NO:";
            // 
            // listIsDebtorcheckBox
            // 
            this.listIsDebtorcheckBox.AutoSize = true;
            this.listIsDebtorcheckBox.Location = new System.Drawing.Point(137, 131);
            this.listIsDebtorcheckBox.Name = "listIsDebtorcheckBox";
            this.listIsDebtorcheckBox.Size = new System.Drawing.Size(15, 14);
            this.listIsDebtorcheckBox.TabIndex = 1;
            this.listIsDebtorcheckBox.UseVisualStyleBackColor = true;
            // 
            // addIdtextBox
            // 
            this.addIdtextBox.Location = new System.Drawing.Point(130, 39);
            this.addIdtextBox.MaxLength = 9;
            this.addIdtextBox.Name = "addIdtextBox";
            this.addIdtextBox.Size = new System.Drawing.Size(171, 26);
            this.addIdtextBox.TabIndex = 6;
            this.addIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addIdtextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID NO:";
            // 
            // Debtorpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 605);
            this.Controls.Add(this.exportPdfButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debtorpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borçlu Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox addIsDebtorCheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox addRevenueIdComboBox;
        private System.Windows.Forms.ComboBox addMemberIdComboBox;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox updateRevenueIdComboBox;
        private System.Windows.Forms.TextBox updateIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox updateMemberIdComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox updateIsDebtorCheckBox;
        private System.Windows.Forms.Button exportPdfButton;
        private GroupBox groupBox3;
        private ComboBox listRevenueIdcomboBox;
        private Label label8;
        private Button listButton;
        private ComboBox listMemberIdcomboBox;
        private Label label10;
        private Label label11;
        private CheckBox listIsDebtorcheckBox;
        private TextBox addIdtextBox;
        private Label label9;
    }
}