﻿namespace _006_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            var clone1 = (Human)original1.Clone();

            Console.WriteLine($"Humans are ref equals: {ReferenceEquals(original1, clone1)}");
            //Console.WriteLine($"Human names are ref equals: {ReferenceEquals(original1.Name, clone1.Name)}"); //remind about string copiing
            Console.WriteLine($"Human skills are ref equals: {ReferenceEquals(original1.Skills, clone1.Skills)}");
            Console.WriteLine($"Human Birthplace are ref equals: {ReferenceEquals(original1.Birthplace, clone1.Birthplace)}");
            Console.WriteLine($"Human skills[0] are ref equals: {ReferenceEquals(original1.Skills[0], clone1.Skills[0])}");

        }
    }
}
