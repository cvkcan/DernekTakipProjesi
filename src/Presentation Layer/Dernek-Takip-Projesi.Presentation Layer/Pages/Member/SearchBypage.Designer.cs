using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Member
{
    partial class SearchBypage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.years2ComboBox = new System.Windows.Forms.ComboBox();
            this.months2ComboBox = new System.Windows.Forms.ComboBox();
            this.years1ComboBox = new System.Windows.Forms.ComboBox();
            this.months1ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bloodTypesComboBox = new System.Windows.Forms.ComboBox();
            this.citiesComboBox = new System.Windows.Forms.ComboBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tcknTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isDebtorCheckBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(878, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(502, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "TÜM ÜYELERİ GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(460, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.years2ComboBox);
            this.groupBox1.Controls.Add(this.months2ComboBox);
            this.groupBox1.Controls.Add(this.years1ComboBox);
            this.groupBox1.Controls.Add(this.months1ComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(502, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 360);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARİH BAZLI BORÇLU ARAMA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(171, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(11, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "BORÇLU MU:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(376, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "ARA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "BİTİŞ TARİHİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "BAŞLANGIÇ TARİHİ:";
            // 
            // years2ComboBox
            // 
            this.years2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.years2ComboBox.FormattingEnabled = true;
            this.years2ComboBox.Location = new System.Drawing.Point(215, 229);
            this.years2ComboBox.Name = "years2ComboBox";
            this.years2ComboBox.Size = new System.Drawing.Size(169, 33);
            this.years2ComboBox.TabIndex = 4;
            // 
            // months2ComboBox
            // 
            this.months2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.months2ComboBox.FormattingEnabled = true;
            this.months2ComboBox.Location = new System.Drawing.Point(15, 229);
            this.months2ComboBox.Name = "months2ComboBox";
            this.months2ComboBox.Size = new System.Drawing.Size(169, 33);
            this.months2ComboBox.TabIndex = 4;
            // 
            // years1ComboBox
            // 
            this.years1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.years1ComboBox.FormattingEnabled = true;
            this.years1ComboBox.Location = new System.Drawing.Point(215, 126);
            this.years1ComboBox.Name = "years1ComboBox";
            this.years1ComboBox.Size = new System.Drawing.Size(167, 33);
            this.years1ComboBox.TabIndex = 4;
            // 
            // months1ComboBox
            // 
            this.months1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.months1ComboBox.FormattingEnabled = true;
            this.months1ComboBox.Location = new System.Drawing.Point(15, 126);
            this.months1ComboBox.Name = "months1ComboBox";
            this.months1ComboBox.Size = new System.Drawing.Size(169, 33);
            this.months1ComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "TCKN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "KAN GRUBU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "ŞEHİR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "AKTİF Mİ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "BORÇLU MU:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "YAŞ:";
            // 
            // bloodTypesComboBox
            // 
            this.bloodTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodTypesComboBox.FormattingEnabled = true;
            this.bloodTypesComboBox.Location = new System.Drawing.Point(182, 54);
            this.bloodTypesComboBox.Name = "bloodTypesComboBox";
            this.bloodTypesComboBox.Size = new System.Drawing.Size(161, 32);
            this.bloodTypesComboBox.TabIndex = 6;
            this.bloodTypesComboBox.TextChanged += new System.EventHandler(this.bloodTypesComboBox_TextChanged);
            // 
            // citiesComboBox
            // 
            this.citiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesComboBox.FormattingEnabled = true;
            this.citiesComboBox.Location = new System.Drawing.Point(182, 113);
            this.citiesComboBox.Name = "citiesComboBox";
            this.citiesComboBox.Size = new System.Drawing.Size(161, 32);
            this.citiesComboBox.TabIndex = 6;
            this.citiesComboBox.TextChanged += new System.EventHandler(this.citiesComboBox_TextChanged);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(182, 171);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 7;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            this.isActiveCheckBox.CheckedChanged += new System.EventHandler(this.isActiveCheckBox_CheckedChanged);
            // 
            // tcknTextBox
            // 
            this.tcknTextBox.Location = new System.Drawing.Point(182, 214);
            this.tcknTextBox.MaxLength = 12;
            this.tcknTextBox.Name = "tcknTextBox";
            this.tcknTextBox.Size = new System.Drawing.Size(140, 29);
            this.tcknTextBox.TabIndex = 8;
            this.tcknTextBox.TextChanged += new System.EventHandler(this.tcknTextBox_TextChanged);
            this.tcknTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcknTextBox_KeyPress);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(182, 272);
            this.ageTextBox.MaxLength = 3;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(140, 29);
            this.ageTextBox.TabIndex = 8;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.ageTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tcknTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.isDebtorCheckBox);
            this.groupBox2.Controls.Add(this.isActiveCheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.citiesComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bloodTypesComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 441);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜYE ARAMA KRİTERLERİ";
            // 
            // isDebtorCheckBox
            // 
            this.isDebtorCheckBox.AutoSize = true;
            this.isDebtorCheckBox.Location = new System.Drawing.Point(182, 340);
            this.isDebtorCheckBox.Name = "isDebtorCheckBox";
            this.isDebtorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isDebtorCheckBox.TabIndex = 7;
            this.isDebtorCheckBox.UseVisualStyleBackColor = true;
            this.isDebtorCheckBox.CheckedChanged += new System.EventHandler(this.isActiveCheckBox_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(706, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "PDF\'e AKTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchBypage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 784);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBypage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox years2ComboBox;
        private System.Windows.Forms.ComboBox months2ComboBox;
        private System.Windows.Forms.ComboBox years1ComboBox;
        private System.Windows.Forms.ComboBox months1ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bloodTypesComboBox;
        private System.Windows.Forms.ComboBox citiesComboBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox tcknTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox isDebtorCheckBox;
        private Button button4;
        private CheckBox checkBox1;
        private Label label8;
    }
}