using Dernek_Takip_Projesi.Data_Access_Layer.DbArea.DbModels;
using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business
{
    public class MemberController
    {
        public bool AddMember(Member member)
        {
            //FluentValidation için member formatında verileri yolladım.
            try
            {
                OleDbCommand cmd = Database.command("INSERT INTO Member([ID],[Name],[Surname],[Age],[Cities],[BloodTypes],[IsActive],[EmailAddress],[PhoneNumber],[Gender]) VALUES (@Id,@Name,@Surname,@Age,@Cities,@BloodTypes,@IsActive,@EmailAddress,@PhoneNumber,@Gender)");
                cmd.Parameters.AddWithValue("@Id", member.Id);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Surname", member.Surname);
                cmd.Parameters.AddWithValue("@Age", member.Age);
                cmd.Parameters.AddWithValue("@Cities", member.Cities);
                cmd.Parameters.AddWithValue("@BloodTypes", member.BloodType);
                cmd.Parameters.AddWithValue("@IsActive", member.IsActive);
                cmd.Parameters.AddWithValue("@EmailAddress", member.EmailAddress);
                cmd.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", member.Gender);
                //Member türündeki verilere karşılık gelen alanları belirttim.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMember(long id)
        {
            try
            {
                OleDbCommand cmd = Database.command("DELETE FROM Member Where Id = @Id");
                cmd.Parameters.AddWithValue("@Id", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateMember(Member member)
        {
            try
            {
                OleDbCommand cmd = Database.command("Update Member SET ID = @id, Name = @name, Surname = @surname, Age = @age, Cities = @citie, BloodTypes = @bloodType, IsActive = @isActive, EmailAddress = @emailAddress, PhoneNumber = @phoneNumber, Gender = @gender WHERE ID = @id");
                cmd.Parameters.AddWithValue("@Id", member.Id);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Surname", member.Surname);
                cmd.Parameters.AddWithValue("@Age", member.Age);
                cmd.Parameters.AddWithValue("@Cities", member.Cities);
                cmd.Parameters.AddWithValue("@BloodTypes", member.BloodType);
                cmd.Parameters.AddWithValue("@IsActive", member.IsActive);
                cmd.Parameters.AddWithValue("@EmailAddress", member.EmailAddress);
                cmd.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", member.Gender);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetMembers()
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member");
            DataTable dt = new DataTable();
            return Database.datatable(cmd);
        }
        public List<Member> GetMembersListFormat()
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member");
            List<Member> members = new List<Member>();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Member member = new Member(Convert.ToInt64(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), (Cities)reader[4], (BloodTypes)reader[5], Convert.ToBoolean(reader[6]), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                members.Add(member);
            }
            //Gelen verileri okuyarak ilgili member türünde oluşturdum ve geriye döndürdüm.
            return members;
        }
        public DataTable GetMembersByBloodTypes(BloodTypes bloodTypes)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member WHERE BloodTypes = @BloodTypes");
            cmd.Parameters.AddWithValue("@BloodTypes", bloodTypes);
            return Database.datatable(cmd);
        }
        public DataTable GetMembersById(long id)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member WHERE ID = @Id");
            cmd.Parameters.AddWithValue("@Id", id);
            return Database.datatable(cmd);
        }
        public DataTable GetMembersByAge(int age)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member WHERE Age = @age");
            cmd.Parameters.AddWithValue("@age", age);
            return Database.datatable(cmd);
        }
        public DataTable GetMembersByCities(Cities cities)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member WHERE Cities = @Cities");
            cmd.Parameters.AddWithValue("@Cities", cities);
            return Database.datatable(cmd);
        }
        public DataTable GetMembersByIsActiveAndIsDebtor(bool isActive,bool isDebtor)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [TCKN/YKN], Name AS [Isim], Surname AS [Soyisim], Age AS [Yaş], Cities AS [Şehir Kodu], BloodTypes AS [Kan Grubu], IsActive AS [Aktif Mi], EmailAddress AS [Email Adresi], PhoneNumber AS [Telefon No], Gender AS [Cinsiyet] FROM Member WHERE IsActive = @IsActive AND IsDebtor = @IsDebtor");
            cmd.Parameters.AddWithValue("@IsDebtor",isDebtor);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
            return Database.datatable(cmd);
        }
        public DataTable GetMembersByIsDebtor(bool isDebtor)
        {
            OleDbCommand cmd = Database.command("SELECT Debtor.IsDebtor, Member.EmailAddress FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE Debtor.IsDebtor = @IsDebtor");
            cmd.Parameters.AddWithValue("@IsDebtor", isDebtor);
            return Database.datatable(cmd);
        }
        public List<string> GetMembersByIsDebtorListFormat()
        {
            List<string> members = new List<string>();
            OleDbCommand cmd = Database.command("SELECT Member.EmailAddress FROM ((Debtor INNER JOIN Member ON Member.Id = Debtor.MemberId) INNER JOIN Revenue ON Revenue.Id = Debtor.RevenueId) WHERE Debtor.IsDebtor = true");
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                members.Add(reader[0].ToString());
            }
            return members;
        }
    }
}