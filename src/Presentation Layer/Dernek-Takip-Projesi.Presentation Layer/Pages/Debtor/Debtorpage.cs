using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using System;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Debtor
{
    public partial class Debtorpage : Form
    {
        private string isUsed = String.Empty;
        private readonly MemberController _memberController;
        private readonly RevenueController _revenueController;
        private readonly DebtorController _debtorController;
        private readonly ExportDgw _exportDgw;
        //DI'larımı tanımladım.
        public Debtorpage(MemberController memberController, RevenueController revenueController, DebtorController debtorController, ExportDgw exportDgw)
        {
            InitializeComponent();
            _memberController = memberController;
            _revenueController = revenueController;
            _debtorController = debtorController;
            _exportDgw = exportDgw;
            GetComboBox();
            //DI'ları ve combobox içerisinde doldurulacak olan verilerimi constructor içerisine gömdüm.
        }

        #region Event Area
        private void addIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        private void updateIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        //Sadece rakam girişini ve silme butonunu aktive ettim.
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addIdtextBox.Text))
            {
                var result = _debtorController.AddDebtor(Convert.ToInt32(addIdtextBox.Text),Convert.ToInt32(addRevenueIdComboBox.SelectedItem.ToString()), Convert.ToInt64(addMemberIdComboBox.SelectedItem.ToString()), addIsDebtorCheckBox.Checked);
                if (result)
                    MessageBox.Show("Ekleme işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ekleme işlemi başarısız. Bilgileri kontrol edip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Gelen sonuca göre bilgilendirme mesajı yolladım.
            }
            else
                MessageBox.Show("Lütfen ID alanını doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Alanın boş olması durumunda bilgilendirilmesini sağladım.
        }
        private void getAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _debtorController.GetDebtorTable();
            //DataGridView içerisindeki verileri doldurdum.
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(updateIdTextBox.Text))
            {
                var result = _debtorController.UpdateDebtor(Convert.ToInt32(updateIdTextBox.Text), Convert.ToInt32(updateRevenueIdComboBox.SelectedItem.ToString()), Convert.ToInt64(updateMemberIdComboBox.SelectedItem.ToString()), updateIsDebtorCheckBox.Checked);
                if (result)
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Güncelleme işlemi başarısız. Bilgileri kontrol edip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen ID alanını doldurunuz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
                _exportDgw.ExportPdf(dataGridView1);
            //Tablo içeriği boş Pdf'e dönüştürme işlemini başlatmadım.
            else
                MessageBox.Show("Tablo boş olduğu için aktarma işlemi gerçekleştirilemez.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _debtorController.GetDebtorTableByCriteria(listRevenueIdcomboBox.SelectedItem.ToString(), listMemberIdcomboBox.SelectedItem.ToString(),listIsDebtorcheckBox.Checked);
        }
        #endregion

        #region Func Area

        private void GetComboBox()
        {
            var datas = _revenueController.GetRevenueId();
            foreach (var item in datas)
            {
                addRevenueIdComboBox.Items.Add(item.Id);
                updateRevenueIdComboBox.Items.Add(item.Id);
                listRevenueIdcomboBox.Items.Add(item.Id);
            }
            var datas2 = _memberController.GetMembersListFormat();
            foreach (var item in datas2)
            {
                addMemberIdComboBox.Items.Add(item.Id);
                updateMemberIdComboBox.Items.Add(item.Id);
                listMemberIdcomboBox.Items.Add(item.Id);
            }
            //Database'den dönen sonuçlara göre kullanıcıya hazır combobox şablonu sunmuş oldum.
            addRevenueIdComboBox.SelectedIndex = 0;
            addMemberIdComboBox.SelectedIndex = 0;
            updateRevenueIdComboBox.SelectedIndex = 0;
            updateMemberIdComboBox.SelectedIndex = 0;
            listMemberIdcomboBox.SelectedIndex = 0;
            listRevenueIdcomboBox.SelectedIndex = 0;
            //Combobox içerisini doldurdum.
        }
        #endregion

        
    }
}