using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using System;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Member
{
    public partial class SearchBypage : Form
    {
        private string isUsed = string.Empty;
        private readonly MemberController _memberController;
        private readonly DebtorController _debtorController;
        private readonly ExportDgw _exportDgw;
        public SearchBypage(MemberController memberController, DebtorController debtorController, ExportDgw exportDgw)
        {
            InitializeComponent();
            GetEnums();
            IsEnabled();
            _memberController = memberController;
            _debtorController = debtorController;
            _exportDgw = exportDgw;
        }
        #region Func Area
        private void IsEnabled()
        {
            //Kullanılan alanlara göre kullanılmayan alanları devre dışı bıraktım.
            if (tcknTextBox.Text.Length >= 1)
            {
                ageTextBox.Enabled = false;
                isDebtorCheckBox.Enabled = false;
                bloodTypesComboBox.Enabled = false;
                citiesComboBox.Enabled = false;
                isActiveCheckBox.Enabled = false;
                isUsed = "Id";
            }
            else if (!string.IsNullOrWhiteSpace(ageTextBox.Text.ToString()))
            {
                tcknTextBox.Enabled = false;
                isDebtorCheckBox.Enabled = false;
                bloodTypesComboBox.Enabled = false;
                citiesComboBox.Enabled = false;
                isActiveCheckBox.Enabled = false;
                isUsed = "Age";
            }
            else if (bloodTypesComboBox.SelectedItem != "---Devre Dışı---")
            {
                ageTextBox.Enabled = false;
                isDebtorCheckBox.Enabled = false;
                tcknTextBox.Enabled = false;
                citiesComboBox.Enabled = false;
                isActiveCheckBox.Enabled = false;
                isUsed = "Blood";
            }
            else if (citiesComboBox.SelectedItem != "---Devre Dışı---")
            {
                ageTextBox.Enabled = false;
                isDebtorCheckBox.Enabled = false;
                tcknTextBox.Enabled = false;
                bloodTypesComboBox.Enabled = false;
                isActiveCheckBox.Enabled = false;
                isUsed = "Citie";
            }
            else
            {
                isUsed = "Both";
                ageTextBox.Enabled = true;
                isDebtorCheckBox.Enabled = true;
                bloodTypesComboBox.Enabled = true;
                citiesComboBox.Enabled = true;
                tcknTextBox.Enabled = true;
                isActiveCheckBox.Enabled = true;
            }
        }

        private void GetEnums()
        {
            citiesComboBox.Items.Add("---Devre Dışı---");
            bloodTypesComboBox.Items.Add("---Devre Dışı---");
            foreach (var item in Enum.GetValues(typeof(Cities)))
            {
                citiesComboBox.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(BloodTypes)))
            {
                bloodTypesComboBox.Items.Add(item);
            }
            months1ComboBox.DataSource = Enum.GetValues(typeof(Months));
            months2ComboBox.DataSource = Enum.GetValues(typeof(Months));
            for (int i = 1888; i <=DateTime.Now.Year+1 ; i++)
            {
                years1ComboBox.Items.Add(i);
                years2ComboBox.Items.Add(i);
            }
            years1ComboBox.SelectedItem = 2023;
            years2ComboBox.SelectedItem = 2023;
            citiesComboBox.SelectedItem = "---Devre Dışı---";
            bloodTypesComboBox.SelectedItem = "---Devre Dışı---";
            //Enum verilerini ve yıl değerlerini combobox'lara ekledim.
        }
        #endregion

        #region Event Area

        private void tcknTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _memberController.GetMembers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enum.TryParse(months1ComboBox.SelectedItem.ToString(),out Months result1);
            Enum.TryParse(months2ComboBox.SelectedItem.ToString(),out Months result2);
            dataGridView1.DataSource = _debtorController.GetDebtorTableDateByDate(result1, result2, Convert.ToInt32(years1ComboBox.SelectedItem), Convert.ToInt32(years2ComboBox.SelectedItem),checkBox1.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isUsed == "Id")
            {
                dataGridView1.DataSource = _memberController.GetMembersById(Convert.ToInt64(tcknTextBox.Text));
            }
            else if (isUsed == "Age")
            {
                dataGridView1.DataSource = _memberController.GetMembersByAge(Convert.ToInt32(ageTextBox.Text));
            }
            else if (isUsed == "Debtor")
            {
                dataGridView1.DataSource = _memberController.GetMembersByIsDebtor(isDebtorCheckBox.Checked);
            }
            else if (isUsed == "Blood")
            {
                Enum.TryParse(bloodTypesComboBox.SelectedItem.ToString(),out BloodTypes bloodResult);
                dataGridView1.DataSource = _memberController.GetMembersByBloodTypes(bloodResult);
            }
            else if (isUsed == "Citie")
            {
                Enum.TryParse(citiesComboBox.SelectedItem.ToString(),out Cities citiesResult);
                dataGridView1.DataSource = _memberController.GetMembersByCities(citiesResult);
            }
            else if (isUsed == "Both")
            {
                dataGridView1.DataSource = _memberController.GetMembersByIsActiveAndIsDebtor(isActiveCheckBox.Checked,isDebtorCheckBox.Checked);
            }
            //Kullanılan alanlara göre ilgili veriler doğrultusunda veritabanında sorgulama yaptım.
        }
        
        private void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }
        //Alanların kullanılmasına göre işlemlerin gerçekleşmesini sağladım.

        private void isDebtorCheckBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnabled();
        }

        private void bloodTypesComboBox_TextChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }

        private void citiesComboBox_TextChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }

        private void tcknTextBox_TextChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>1)
                _exportDgw.ExportPdf(dataGridView1);
            else
                MessageBox.Show("Tabloda veri olmadığı için veri PDF'e dönüştürme başarısız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}