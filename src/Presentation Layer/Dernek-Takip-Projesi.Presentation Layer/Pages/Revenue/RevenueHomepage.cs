using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using System;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Revenue
{
    public partial class RevenueHomepage : Form
    {
        private readonly RevenueController _revenueController;
        public RevenueHomepage(RevenueController revenueController)
        {
            InitializeComponent();
            _revenueController = revenueController;
            GetDgwDatas();
        }

        #region Event Area

        private void button1_Click(object sender, EventArgs e)
        {
            AddRevenuepage addRevenuepage = new AddRevenuepage(_revenueController);
            addRevenuepage.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Equals(String.Empty))
                dataGridView1.DataSource = _revenueController.GetRevenueById(Convert.ToInt32(textBox1.Text));
            else
                MessageBox.Show("Lütfen arama değeri giriniz.", "Biglilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDgwDatas();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        #endregion

        #region Func Area

        private void GetDgwDatas()
        {
            dataGridView1.DataSource = _revenueController.GetRevenue();
        }

        #endregion

    }
}
