using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Email
{
    public partial class SendMailpage : Form
    {
        private readonly EmailController _emailController;
        private readonly bool isNull;
        private readonly List<string> members;
        //Textbox alanının ve üye listesinin bir önceki formdan geldiğinde karşılanmasını sağlamış oldun.
        public SendMailpage(EmailController emailController,List<string> members,bool isNull)
        {
            InitializeComponent();
            _emailController = emailController;
            this.isNull = isNull;
            this.members= members;
            isEnabled();
            //İlgili alanları doldurtmuş oldum.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> mail = new List<string>();
            //Liste formatındaki parametre için string dizisi oluşturdum.
            if (!isNull)
            {
                foreach (var item in members)
                {
                    mail.Add(item);
                }
                var result = _emailController.SendMail(subjectTextBox.Text, bodyTextBox.Text, ccTextBox.Text, mail);
                //Toplu veri gelmesi durumunda mail kısmını doldurdum. Tekil gelmesi durumunda ise listeye sadece 1 adet email adresi eklettim.
                if (result)
                    MessageBox.Show("Email'ler başarıyla gönderilmiştir.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("Email'ler gönderilemedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                mail.Add(textBox1.Text);
                var result = _emailController.SendMail(subjectTextBox.Text, bodyTextBox.Text, ccTextBox.Text, mail);
                if (result)
                    MessageBox.Show("Email'ler başarıyla gönderilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Email'ler gönderilemedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void isEnabled()
        {
            if (isNull)
            {
                label4.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox1.Visible = false;
            }
            //Textbox alanının görünürlüğünü ayarlamış oldum.
        }
    }
}
