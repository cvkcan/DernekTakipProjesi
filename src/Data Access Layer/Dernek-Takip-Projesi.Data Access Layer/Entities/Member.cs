using Dernek_Takip_Projesi.Data_Access_Layer.Entities.Common;
using Dernek_Takip_Projesi.Data_Access_Layer.Enums;

namespace Dernek_Takip_Projesi.Data_Access_Layer.Entities
{
    public class Member : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Cities Cities { get; set; }
        public BloodTypes BloodType { get; set; }
        //Enum türünde şehir ve kangrubunu tanımladım.
        public bool IsActive { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

        public Member(long id, string name, string surname, int age, Cities cities, BloodTypes bloodTypes, bool isactive, string emailAdress, string phoneNumber, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Cities = cities;
            this.BloodType = bloodTypes;
            this.IsActive = isactive;
            this.EmailAddress = emailAdress;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
        }
        public Member()
        {

        }
        //Parametresiz kullanım için de Constructor tanımladım.
    }
}
