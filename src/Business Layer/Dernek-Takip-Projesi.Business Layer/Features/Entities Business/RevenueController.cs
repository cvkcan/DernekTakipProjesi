using Dernek_Takip_Projesi.Data_Access_Layer.DbArea.DbModels;
using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business
{
    public class RevenueController
    {
        public bool AddRevenue(Revenue revenue)
        {
            try
            {
                OleDbCommand cmd = Database.command("INSERT INTO Revenue ([ID],[Fee], [Month], [Year]) VALUES (@Id ,@Fee, @Month, @Year)");
                cmd.Parameters.AddWithValue("@Id",revenue.Id);
                cmd.Parameters.AddWithValue("@Fee", revenue.Fee);
                cmd.Parameters.AddWithValue("@Month", revenue.Month);
                cmd.Parameters.AddWithValue("@Year", revenue.Year);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateRevenue(Revenue revenue)
        {
            try
            {
                OleDbCommand cmd = Database.command("UPDATE Revenue SET [ID] = @ID, [Fee] = @Fee, [Month] = @Month, [Year] = @Year WHERE [ID] = @ID");
                cmd.Parameters.AddWithValue("@ID", revenue.Id);
                cmd.Parameters.AddWithValue("@Fee", revenue.Fee);
                cmd.Parameters.AddWithValue("@Month", revenue.Month);
                cmd.Parameters.AddWithValue("@Year", revenue.Year);
                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetRevenueById(int id)
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [Id],Fee AS [Ucret], Month As [Ay], Year AS [Yıl] FROM Revenue Where ID = @ID");
            cmd.Parameters.AddWithValue("@ID", id);
            return Database.datatable(cmd);
        }
        public DataTable GetRevenue()
        {
            OleDbCommand cmd = Database.command("SELECT ID AS [No],Fee AS [Ucret], Month As [Ay], Year AS [Yıl] FROM Revenue");
            return Database.datatable(cmd);
        }
        public List<Revenue> GetRevenueId()
        {
            List<Revenue> revenues = new List<Revenue>();
            OleDbCommand cmd = Database.command("SELECT * FROM Revenue");
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Revenue revenue = new Revenue(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), (Months)reader[2], Convert.ToInt32(reader[3]));
                revenues.Add(revenue);
            }
            return revenues;
        }
    }
}
