using System.ComponentModel.DataAnnotations;

namespace H.W_9.Member
{
    public class User
    {
        public class Member
        {
            [Key]
            public int ID { get; set; }
            [Required]
            public string? Name { get; set; }
            public string? LastName { get; set; }
            public DateTime DOR { get; set; } = DateTime.Now;//date of regestring
            public DateTime DOB { get; set; } //date of birthday
            [Required]
            public int NationalCode { get; set; }
            public string? MembershipType { get; set; }
            public int PhoneNumber { get; set; }
            public bool Gender { get; set; }
            public virtual List<User>? Users { get; set; }


            public void Regester(int Id, string _Name, string lastname, DateTime dob, int _NAtionalCode, string membershiptyoe, int phonenumber, bool gender)
            {
                
                ID = Id;
                
                Name = _Name;
                LastName = lastname;
                DOB = dob;
                NationalCode = _NAtionalCode;
                MembershipType = membershiptyoe;
                PhoneNumber = phonenumber;
                Gender = gender;



                Console.WriteLine("please fill the requierd values:");
                    Id = Convert.ToInt32(Console.ReadLine);
                _Name = Console.ReadLine();
                LastName = Console.ReadLine();
                dob = DateTime.UtcNow;
                _NAtionalCode = Convert.ToInt32(Console.ReadLine());
                phonenumber = Convert.ToInt32(Console.ReadLine());
                gender = true;

             
            }


            public void Find(Member member)
            {
                string _Name = Console.ReadLine();
                string _LastName = Console.ReadLine();
                
            }

        }
    }
}
