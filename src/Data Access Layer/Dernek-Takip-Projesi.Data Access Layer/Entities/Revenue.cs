using Dernek_Takip_Projesi.Data_Access_Layer.Entities.Common;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;

namespace Dernek_Takip_Projesi.Data_Access_Layer.Entities
{
    public class Revenue : BaseEntity
    {
        public int Fee { get; set; }
        public Months Month { get; set; }
        public int Year { get; set; }
        public Revenue(int id, int fee, Months months, int year)
        {
            this.Id = id;
            this.Fee = fee;
            this.Month = months;
            this.Year = year;
        }
        public Revenue()
        {

        }
    }
}
