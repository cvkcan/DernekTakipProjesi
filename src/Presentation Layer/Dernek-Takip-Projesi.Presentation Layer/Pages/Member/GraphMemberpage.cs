using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using path = Dernek_Takip_Projesi.Data_Access_Layer.Entities;

namespace Dernek_Takip_Projesi.Presentation_Layer.Pages.Member
{
    public partial class GraphMemberpage : Form
    {
        private readonly MemberController _memberController;
        private readonly DebtorController _debtorController;
        public GraphMemberpage(MemberController memberController, DebtorController debtorController)
        {
            InitializeComponent();
            _memberController = memberController;
            _debtorController = debtorController;
            DrawGraphByCities(_memberController.GetMembersListFormat());
            DrawGraphByIsActive(_memberController.GetMembersListFormat());
            DrawGraphByMonthFee(_debtorController.GetDebtorTableMonthFee());
            DrawGraphByYearFee(_debtorController.GetDebtorTableYearFee());
            //Constructor içerisinde tabloların doldurulması için kodu çalıştırdım.
        }

        #region Func Area

        private void DrawGraphByYearFee(Dictionary<string, string> data)
        {
            GraphPane myPane = zedGraphControl3.GraphPane;
            //Grafik ekranını oluşturdum.
            myPane.Title.Text = "Yıllık Aidat Geliri";
            myPane.XAxis.Title.Text = "Yıllar";
            myPane.YAxis.Title.Text = "Toplam Aidat Geliri x10";
            //x,y ve başlık adlarını yazdım.
            int index = 0;
            List<Color> colors = GenerateRandomColors(data.Count);
            //Rastgele renk seçmesini sağladım.
            foreach (var entry in data)
            {
                string year = entry.Key;
                double fee = Convert.ToDouble(entry.Value) / 10;
                //Directory formatındaki verilerdeki Key ve Value'yu alarak x ve y eksenlerindeki değerlere ekleyeceğim.
                if (index < colors.Count)
                {
                    Color barColor = colors[index];
                    BarItem myBar = myPane.AddBar(year, new double[] { index }, new double[] { fee }, barColor);
                    index++;
                    //Bar şeklindeki grafiği oluşturarark her bir ilerleme sonrasında indexi arttırarak bir sonraki alana geçmesini sağladım.
                }
            }
            zedGraphControl3.AxisChange();
            zedGraphControl3.Invalidate();
            //Grafiklerin gösterilmesi ve yeniden çizilmesini sağlar.
        }
        private void DrawGraphByCities(List<path.Member> datas)
        {
            Dictionary<string, int> nameCounts = new Dictionary<string, int>();
            foreach (var member in datas)
            {
                if (nameCounts.ContainsKey(member.Cities.ToString()))
                    nameCounts[member.Cities.ToString()]++;
                else
                    nameCounts[member.Cities.ToString()] = 1;
            }
            //Datas içerisinde dönerek şehileri ekledim.Şehir geçiyorsa değeri 1 arttırdım.Geçmiyorsa bir sonraki şehre geçip aynı işlemi yaptım.
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Şehir Sayıları";
            myPane.XAxis.Title.Text = "Şehirler";
            myPane.YAxis.Title.Text = "Kişi Sayısı x10";
            int index = 0;
            List<Color> colors = GenerateRandomColors(nameCounts.Count);
            foreach (var nameCount in nameCounts)
            {
                if (index < colors.Count)
                {
                    Color randomColor = colors[index];
                    BarItem myBar = myPane.AddBar(nameCount.Key, new double[] { index }, new double[] { nameCount.Value }, randomColor);
                    index++;
                }
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
        private void DrawGraphByMonthFee(Dictionary<string, string> data)
        {
            GraphPane myPane = zedGraphControl2.GraphPane;
            myPane.Title.Text = "Aylık Aidat Geliri";
            myPane.XAxis.Title.Text = "Aylar";
            myPane.YAxis.Title.Text = "Toplam Aidat Geliri x10";
            int index = 0;
            List<Color> colors = GenerateRandomColors(data.Count);
            foreach (var entry in data)
            {
                string month = entry.Key;
                double fee = Convert.ToDouble(entry.Value) / 10;
                if (index < colors.Count)
                {
                    Color barColor = colors[index];
                    BarItem myBar = myPane.AddBar(month, new double[] { index }, new double[] { fee }, barColor);
                    index++;
                }
            }
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }
        private void DrawGraphByIsActive(List<path.Member> datas)
        {
            Dictionary<string, int> nameCounts = new Dictionary<string, int>();
            foreach (var member in datas)
            {
                string isActiveTurkishMean;
                if (member.IsActive)
                    isActiveTurkishMean = "Aktif";
                else
                    isActiveTurkishMean = "Pasif";
                if (nameCounts.ContainsKey(isActiveTurkishMean))
                    nameCounts[isActiveTurkishMean]++;
                else
                    nameCounts[isActiveTurkishMean] = 1;
            }
            //Aktif ve Pasif üye sayılarını belirledim.
            GraphPane myPane = zedGraphControl4.GraphPane;
            myPane.Title.Text = "Üye Sayıları";
            myPane.XAxis.Title.Text = "Durum";
            myPane.YAxis.Title.Text = "Kişi Sayısı";
            int index = 0;
            List<Color> colors = GenerateRandomColors(nameCounts.Count);
            foreach (var nameCount in nameCounts)
            {
                if (index < colors.Count)
                {
                    Color randomColor = colors[index];
                    BarItem myBar = myPane.AddBar(nameCount.Key, new double[] { index }, new double[] { nameCount.Value }, randomColor);
                    index++;
                }
            }
            zedGraphControl4.AxisChange();
            zedGraphControl4.Invalidate();
        }

        private List<Color> GenerateRandomColors(int count)
        {
            List<Color> colors = new List<Color>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                while (colors.Contains(randomColor))
                {
                    randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
                colors.Add(randomColor);
            }
            return colors;
        }
        //Rastgele renk üretmesini sağladım. 

        #endregion
    }
}
