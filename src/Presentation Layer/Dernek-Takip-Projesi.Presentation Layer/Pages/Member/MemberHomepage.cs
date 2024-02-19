using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using System;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Member
{
    public partial class MemberHomepage : Form
    {
        readonly MemberController _memberController;
        readonly EmailController _emailController;
        readonly DebtorController _debtorController;
        readonly ExportDgw _exportDgw;
        public MemberHomepage(MemberController memberController, EmailController emailController, ExportDgw exportDgw, DebtorController debtorController)
        {
            InitializeComponent();
            _memberController = memberController;
            _emailController = emailController;
            _debtorController = debtorController;
            _exportDgw = exportDgw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdateDeletepage getMemberpage = new AddUpdateDeletepage(_memberController,_emailController,_exportDgw,_debtorController);
            getMemberpage.ShowDialog();
            //DI verilerini forms sayfalarına yolladım.
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GraphMemberpage graphMemberpage = new GraphMemberpage(_memberController,_debtorController);
            graphMemberpage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBypage searchBypage = new SearchBypage(_memberController,_debtorController,_exportDgw);
            searchBypage.ShowDialog();
        }
    }
}
