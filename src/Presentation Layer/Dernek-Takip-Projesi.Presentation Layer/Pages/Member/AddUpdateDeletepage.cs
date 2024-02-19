using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using Dernek_Takip_Projesi.Business_Layer.Validations;
using entities = Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using Dernek_Takip_Projesi.Presentation_Layer.Pages.Email;
using FluentValidation.Results;
//FluentValidation kütüphanesini ekledim.
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Member
{

    public partial class AddUpdateDeletepage : Form
    {
        private readonly MemberController _memberController;
        private readonly EmailController _emailController;
        private readonly DebtorController _debtorController;
        private readonly ExportDgw _exportDgw;
        public AddUpdateDeletepage(MemberController memberController, EmailController emailController, ExportDgw exportDgw, DebtorController debtorController)
        {
            InitializeComponent();
            GetEnums();
            _memberController = memberController;
            _emailController = emailController;
            _debtorController = debtorController;
            _exportDgw = exportDgw;
        }
      
        #region Func Area
        private void GetEnums()
        {
            genderComboBox.Items.Add("Erkek");
            genderComboBox.Items.Add("Kadın");
            genderComboBox.SelectedIndex = 0;
            citiesComboBox.DataSource = Enum.GetValues(typeof(Cities));
            bloodTypesComboBox.DataSource = Enum.GetValues(typeof(BloodTypes));
            //Enum değerlerin doldurulmasını sağladım.
            //Enumdan veri okunmasu için verileri Enum türlerine göre belirterek yakaladım.
        }
        private bool IsValid(entities.Member member)
        {
            //FluentValidation için validation fonksiyonunu tanımladım.
            string errorMessage = string.Empty;
            MemberValidator validations = new MemberValidator();
            //Membervalidator sınıfnın oluşturdum.
            ValidationResult validationResult = validations.Validate(member);
            //Member bilgilerini validator'e tabi tuttum.
            if (!validationResult.IsValid)
            {
                foreach (var item in validationResult.Errors)
                {
                    errorMessage += item.ErrorMessage + "\n";
                }
                MessageBox.Show(errorMessage, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Valid (doğrulanmış) durumda değilse toplu bir hata mesajı fırlattım.
                return false;
            }
            else
            
            {
                return true;
            }
        }
        private entities.Member GetMemberData()
        {
            Enum.TryParse(citiesComboBox.SelectedItem.ToString(), out Cities citiesResult);
            Enum.TryParse(bloodTypesComboBox.SelectedItem.ToString(), out BloodTypes bloodTypesResult);
            entities.Member member = new entities.Member();
            //Enum verilerini elde ettikten sonra member sınıfındaki verileri oluşturdum.
            try
            {
                member.Name = nameTextBox.Text;
                member.Surname = surnameTextBox.Text;
                member.BloodType = bloodTypesResult;
                member.Cities = citiesResult;
                member.EmailAddress = emailAddressTextBox.Text;
                member.Gender = genderComboBox.SelectedItem.ToString();
                member.IsActive = isActiveCheckBox.Checked;
                member.PhoneNumber = maskedTextBox1.Text;
                member.Id = Convert.ToInt64(tcknTextBox.Text);
                member.Age = Convert.ToInt32(ageTextBox.Text);
            }
            catch (Exception ex)
            {
                return member;
            }
            return member;
        }
        #endregion

        #region Event Area

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _memberController.GetMembers();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SendMailpage sendMailpage;
            if (_memberController.GetMembersByIsDebtor(true).Equals(null))
                sendMailpage = new SendMailpage(_emailController, null, true);
            else
                sendMailpage = new SendMailpage(_emailController, _memberController.GetMembersByIsDebtorListFormat(), false);
            sendMailpage.ShowDialog();
            //Mail sayfasını oluştururken gönderilecek parametreleri oluşturarak sınıf içerisine ekledim.
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
                _exportDgw.ExportPdf(dataGridView1);
            else
                MessageBox.Show("Tabloda veri olmadığı için veri PDF'e dönüştürme başarısız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var data = GetMemberData();
            if (IsValid(data))
            {
                //Validasyona tabii tuttum.
                if (_memberController.AddMember(data))
                {
                    MessageBox.Show("Üye ekleme başarılı olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Üye eklenemedi. İlgili alanları kontrol ediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!tcknTextBox.Text.ToString().Equals(String.Empty))
            {
                var results = _memberController.DeleteMember(Convert.ToInt64(tcknTextBox.Text));
                if (results)
                    MessageBox.Show("Üye silme başarılı olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Üye silinemedi. İlgili alanları kontrol ediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("İlgili alanları lütfen doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var data = GetMemberData();
            if (IsValid(data))
            {
                if (_memberController.UpdateMember(data))
                    MessageBox.Show("Üye güncelleme başarılı olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Üye güncellenemedi. İlgili alanları kontrol ediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            var ss = _memberController.GetMembersByIsDebtorListFormat();
            foreach (var member in ss)
            {
                list.Add(member);
            }
            var results = _emailController.SendMail(null, null, null, list);
            //Sabit değerlerle toplu borçlu maili yollamış oldum.
            if (results)
                MessageBox.Show("Borçu üyelere mail atma başarılı olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Borçu üyelere mail atma başarısız olmuştur. Lütfen internet bağlantınızı, üye mail adreslerini kontrol ediniz. İlgili alanları kontrol ediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> list = new List<string>();
            foreach (DataGridViewCell item in dataGridView1.Rows[e.RowIndex].Cells)
            {
                list.Add(item.Value.ToString());
            }
            tcknTextBox.Text = list[0].ToString();
            nameTextBox.Text = list[1].ToString();
            surnameTextBox.Text = list[2].ToString();
            ageTextBox.Text = list[3].ToString();
            citiesComboBox.SelectedIndex = Convert.ToInt32(list[4]) - 1;
            bloodTypesComboBox.SelectedIndex = Convert.ToInt32(list[5]) - 1;
            isActiveCheckBox.Checked = Convert.ToBoolean(list[6]);
            emailAddressTextBox.Text = list[7].ToString();
            maskedTextBox1.Text = list[8].ToString();
            genderComboBox.SelectedItem = list[9].ToString();
            //Güncelleme işleminin kolaylığı için tablodaki alanlara tıklandığı zaman ekrandaki bilgileri ilgili alanlara dolduracak kodu yazdım.
        }

        #endregion

        private void button5_Click_1(object sender, EventArgs e)
        {
            SendMailpage sendMailpage = new SendMailpage(_emailController,null,true);
            sendMailpage.ShowDialog();
            //Mail sayfasını oluşturdum.
        }
    }
}
