using Dernek_Takip_Projesi.Data_Access_Layer.DbArea.DbModels;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business
{
    public class DebtorController
    {
        public bool AddDebtor(int id, int revenueId, long memberId, bool isDebtor)
        {
			try
			{
                OleDbCommand cmd = Database.command("INSERT INTO Debtor ([ID], [RevenueId], [MemberId], [IsDebtor]) VALUES (@Id, @RevenueId, @MemberId, @IsDebtor)");
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.Parameters.AddWithValue("@RevenueId", revenueId);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("IsDebtor", isDebtor);
                //Sorguyu Command içerisine yerleştirdim ve parametreleri ekledim.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
                //Verilerin eklenip eklenmediğini kontrol ederek true false değerini yolladım.
            }
			catch (Exception ex)
			{
                return false;
			}
        }
        public bool UpdateDebtor(int id,int revenueId, long memberId, bool isDebtor)
        {
            try
            {
                OleDbCommand cmd = Database.command("UPDATE Debtor SET ID = @Id, RevenueId = @RevenueId, MemberId = @MemberId, IsDebtor = @IsDebtor WHERE ID = @Id");
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.Parameters.AddWithValue("@RevenueId", revenueId);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("IsDebtor", isDebtor);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetDebtorTableByCriteria(string revenueId,string memberId, bool isDebtor)
        {
            //Gelen borclu durumuna göre çalışacak sorguyu yazdım. Tek kodda yazılmamasının sebebi Access karmaşık sorgu olarak tanımlamakta.
            OleDbCommand cmd;
            if (isDebtor.Equals(true))
            {
                cmd = Database.command("SELECT Debtor.Id AS [ID],Debtor.RevenueId AS [Aidat No], Debtor.MemberId AS [Üye TCKN], Debtor.IsDebtor AS [Borclu Mu], Revenue.Fee AS [Ucret], Revenue.Month AS [Ay], Revenue.Year AS [Yıl], Member.Name AS [Adı], Member.Surname AS [Soyadı], Member.Cities AS [Sehir], Member.BloodTypes AS [Kan Grubu], Member.IsActive AS [Aktif Mi], Member.EmailAddress AS [Email Adresi], Member.PhoneNumber AS [Telefon No], Member.Gender AS [Cinsiyet], Member.Age AS [Yaş] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE Debtor.RevenueId = @RevenueId AND Debtor.MemberId = @MemberId AND Debtor.IsDebtor = true ORDER BY Debtor.MemberId ASC");
            }
            else
            {
                cmd = Database.command("SELECT Debtor.Id AS [ID],Debtor.RevenueId AS [Aidat No], Debtor.MemberId AS [Üye TCKN], Debtor.IsDebtor AS [Borclu Mu], Revenue.Fee AS [Ucret], Revenue.Month AS [Ay], Revenue.Year AS [Yıl], Member.Name AS [Adı], Member.Surname AS [Soyadı], Member.Cities AS [Sehir], Member.BloodTypes AS [Kan Grubu], Member.IsActive AS [Aktif Mi], Member.EmailAddress AS [Email Adresi], Member.PhoneNumber AS [Telefon No], Member.Gender AS [Cinsiyet], Member.Age AS [Yaş] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE Debtor.RevenueId = @RevenueId AND Debtor.MemberId = @MemberId AND Debtor.IsDebtor = false ORDER BY Debtor.MemberId ASC");
            }
            cmd.Parameters.AddWithValue("@RevenueId", revenueId);
            cmd.Parameters.AddWithValue("@MemberId", memberId);
            return Database.datatable(cmd);
            //Datatable koduna yönlendirerek DataTable'ı newlemeden kullanmış oldum.
        }   
        public DataTable GetDebtorTable()
        {
            OleDbCommand cmd = Database.command("SELECT Debtor.Id AS [ID],Debtor.RevenueId AS [Aidat No], Debtor.MemberId AS [Üye TCKN], Debtor.IsDebtor AS [Borclu Mu], Revenue.Fee AS [Ucret], Revenue.Month AS [Ay], Revenue.Year AS [Yıl], Member.Name AS [Adı], Member.Surname AS [Soyadı], Member.Cities AS [Sehir], Member.BloodTypes AS [Kan Grubu], Member.IsActive AS [Aktif Mi], Member.EmailAddress AS [Email Adresi], Member.PhoneNumber AS [Telefon No], Member.Gender AS [Cinsiyet], Member.Age AS [Yaş] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) ORDER BY Debtor.RevenueId DESC");
            return Database.datatable(cmd);
        }
        public DataTable GetDebtorTableDateByDate(Months m1, Months m2, int y1, int y2,bool isDebtor)
        {
            OleDbCommand cmd;
            if (isDebtor.Equals(true))
            {
                cmd = Database.command("SELECT Debtor.RevenueId AS [Aidat No], Debtor.MemberId AS [Üye TCKN], Debtor.IsDebtor AS [Borclu Mu], Revenue.Fee AS [Ucret], Revenue.Month AS [Ay], Revenue.Year AS [Yıl], Member.Name AS [Adı], Member.Surname AS [Soyadı], Member.Cities AS [Sehir], Member.BloodTypes AS [Kan Grubu], Member.IsActive AS [Aktif Mi], Member.EmailAddress AS [Email Adresi], Member.PhoneNumber AS [Telefon No], Member.Gender AS [Cinsiyet], Member.Age AS [Yaş] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE ((Revenue.Month >= @m1 AND Revenue.Month <=@m2) AND (Revenue.Year >=@y1 AND Revenue.Year <=@y2)) AND (Debtor.IsDebtor = true)");
            }
            else
            {
                 cmd = Database.command("SELECT Debtor.RevenueId AS [Aidat No], Debtor.MemberId AS [Üye TCKN], Debtor.IsDebtor AS [Borclu Mu], Revenue.Fee AS [Ucret], Revenue.Month AS [Ay], Revenue.Year AS [Yıl], Member.Name AS [Adı], Member.Surname AS [Soyadı], Member.Cities AS [Sehir], Member.BloodTypes AS [Kan Grubu], Member.IsActive AS [Aktif Mi], Member.EmailAddress AS [Email Adresi], Member.PhoneNumber AS [Telefon No], Member.Gender AS [Cinsiyet], Member.Age AS [Yaş] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE ((Revenue.Month >= @m1 AND Revenue.Month <=@m2) AND (Revenue.Year >=@y1 AND Revenue.Year <=@y2)) AND (Debtor.IsDebtor = false)");
            }
            cmd.Parameters.AddWithValue("@m1", m1);
            cmd.Parameters.AddWithValue("@m2", m2);
            cmd.Parameters.AddWithValue("@y1", y1);
            cmd.Parameters.AddWithValue("@y2", y2);
            return Database.datatable(cmd);
        }
        public Dictionary<string, string> GetDebtorTableMonthFee()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //Dictionary Collections'ını kullandım.
            OleDbCommand cmd = Database.command("SELECT Revenue.Month AS [Ay], SUM(Revenue.Fee) AS [Toplam Aidat Geliri] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) GROUP BY Revenue.Month ORDER BY Revenue.Month ASC;");
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                keyValuePairs.Add(reader[0].ToString(), reader[1].ToString());
                //Gelen verilerden işime yarayacak olan 1. ve 2. sütundaki verileri aldım.
            }
            return keyValuePairs;
        }
        public Dictionary<string,string> GetDebtorTableYearFee()
        {
             Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            OleDbCommand cmd = Database.command("SELECT Revenue.Year AS [Yıl], SUM(Revenue.Fee) AS [Toplam Aidat Geliri] FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) GROUP BY Revenue.Year ORDER BY Revenue.Year ASC;");
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                keyValuePairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            return keyValuePairs;
        }
    }
}