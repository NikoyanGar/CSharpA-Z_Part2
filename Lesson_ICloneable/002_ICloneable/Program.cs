namespace _002_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human originalHuman = new Human();

            // Set data for all properties of originalHuman instance
            originalHuman.Name = "John Doe";
            originalHuman.Age = 25;
            originalHuman.Gender = "Male";
            originalHuman.Height = 180;
            originalHuman.Weight = 75;
            originalHuman.Skills = new List<Skill>
                {
                    new Skill { Name = "Programming", Description = "Write code" },
                    new Skill { Name = "Cooking", Description = "Make food" }
                };

            //or
            Human original1 = new Human(
                name: "John Doe",
                age: 25,
                gender: "Male",
                nationality: "",
                occupation: "",
                address: "",
                phoneNumber: "",
                email: "email@gmail.com",
                education: "",
                maritalStatus: "",
                religion: "SomeReligion",
                bloodType: "+1",
                eyeColor: "SomeEyeColor",
                hairColor: "SomeHairColor",
                height: 180,
                weight: 90,
                birthplace: new Birthplace("Yerevan", "Armenia"),
                favoriteColor: "Green",
                hobbies: " hobby1, hobby2, hobby3",
                skills: new List<Skill>
                {
                    new Skill { Description = "Write C# Code", Name = "Coding" },
                    new Skill { Name = "someskil", Description="SomeDesc" }
                },
                languages: "Arm,En,Ru",
                socialMedia: "FB",
                bio: "Some bio text"
            );

            // Clone originalHuman instance Shallow copy
        }
    }
}
