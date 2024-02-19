using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using Dernek_Takip_Projesi.Business_Layer.Validations;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using FluentValidation.Results;
using System;
using System.Windows.Forms;
using entities = Dernek_Takip_Projesi.Data_Access_Layer.Entities;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Revenue
{
    public partial class AddRevenuepage : Form
    {
        private readonly RevenueController _revenueController;
        public AddRevenuepage(RevenueController revenueController)
        {
            InitializeComponent();
            GetEnum();
            comboBox2.SelectedItem = DateTime.Now.Year;
            _revenueController = revenueController;
        }

        #region Event Area
        private void button2_Click(object sender, EventArgs e)
        {
            //Validasyon uyguladım. Dönen değere göre mesaj yansıttım.
            var data = GetRevenueData(textBox1.Text);
            if (IsValid(data))
            {
                
                if (_revenueController.UpdateRevenue(data))
                {
                    MessageBox.Show("Güncelleme işlemi başaralı olmuştur.","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = GetRevenueData(textBox1.Text);
            if (IsValid(data))
            {
                var result = _revenueController.AddRevenue(data);
                if (result)
                {
                    MessageBox.Show($"ID'si {textBox1.Text + " Yılı" + comboBox2.Text + " Ayı" + comboBox1.Text} olan aidat eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"{comboBox2.Text + comboBox1.Text} aidatı eklenememiştir. Bilgileri kontrol ediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        //Rakamları ve control tuşlarının kullanılmasını sağladım.
        #endregion

        #region Func Area

        private bool IsValid(entities.Revenue revenue)
        {
            //FluentValidation kullanarak doğrulama yapılmasını sağladım.
            string errorMessage = string.Empty;
            RevenueValidator validations = new RevenueValidator();
            ValidationResult validationResult = validations.Validate(revenue);
            if (!validationResult.IsValid)
            {
                foreach (var item in validationResult.Errors)
                {
                    errorMessage += item.ErrorMessage + "\n";
                }
                MessageBox.Show(errorMessage, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private entities.Revenue GetRevenueData(string id = null)
        {
            //Aidat verilerini oluşturdum.
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out Months monthsResult);
            entities.Revenue revenue = new entities.Revenue();
            try
            {
                revenue.Month = monthsResult;
                revenue.Year = Convert.ToInt32(comboBox2.Text);
                revenue.Id = Convert.ToInt32(id);
                revenue.Fee = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex)
            {
                return revenue;
            }          
            return revenue;
        }

        private void GetEnum()
        {
            for (int i = 1888; i <= DateTime.Now.Year + 1; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox1.DataSource = Enum.GetValues(typeof(Months));
        }
        #endregion
    }
}
