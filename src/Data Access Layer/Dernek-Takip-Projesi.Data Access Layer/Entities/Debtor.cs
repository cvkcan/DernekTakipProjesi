using Dernek_Takip_Projesi.Data_Access_Layer.Entities.Common;

namespace Dernek_Takip_Projesi.Data_Access_Layer.Entities
{
    public class Debtor : BaseEntity
    {
        public int RevenueId { get; set; }
        public int MemberId { get; set; }
        public bool IsDebtor { get; set; }
        public Debtor(int id, int revenueId, int memberId, bool isDebtor)
        {
            this.Id = id;
            this.RevenueId = revenueId;
            this.MemberId = memberId;
            this.IsDebtor = isDebtor;
        }
        //İlgili alanları belirterek parametreli consturctor'ı tanımladım.
    }
}
