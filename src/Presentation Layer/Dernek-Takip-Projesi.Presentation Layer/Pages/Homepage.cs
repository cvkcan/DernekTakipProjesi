using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using Dernek_Takip_Projesi.Presentation_Layer.Pages.Debtor;
using Dernek_Takip_Projesi.Presentation_Layer.Pages.Member;
using Dernek_Takip_Projesi.Presentation_Layer.Pages.Revenue;
using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages
{
    public partial class Homepage : Form
    {
        private readonly MemberController _memberController;
        private readonly RevenueController _revenueController;
        private readonly EmailController _emailController;
        private readonly DebtorController _debtorController;
        private readonly ExportDgw _exportDgw;
        public Homepage(MemberController memberController, RevenueController revenueController, EmailController emailController, ExportDgw exportDgw, DebtorController debtorController)
        {
            InitializeComponent();
            _memberController = memberController;
            _revenueController = revenueController;
            _emailController = emailController;
            _debtorController = debtorController;
            _exportDgw = exportDgw;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberHomepage memberpage = new MemberHomepage(_memberController, _emailController,_exportDgw,_debtorController);
            memberpage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RevenueHomepage revenuepage = new RevenueHomepage(_revenueController);
            revenuepage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debtorpage debtorpage = new Debtorpage(_memberController,_revenueController,_debtorController,_exportDgw);
            debtorpage.ShowDialog();
        }
    }
}
