﻿namespace _009_ICloneable
{
    //[DataContract]
    public class Human : ICloneable
    {
        public Human()
        {
        }
        public Human(string name,
                     int age,
                     string gender,
                     string nationality,
                     string occupation,
                     string address,
                     string phoneNumber,
                     string email,
                     string education,
                     string maritalStatus,
                     string religion,
                     string bloodType,
                     string eyeColor,
                     string hairColor,
                     double height,
                     double weight,
                     Birthplace birthplace,
                     string favoriteColor,
                     string hobbies,
                     List<Skill> skills,
                     string languages,
                     string socialMedia,
                     string bio)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Nationality = nationality;
            Occupation = occupation;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Education = education;
            MaritalStatus = maritalStatus;
            Religion = religion;
            BloodType = bloodType;
            EyeColor = eyeColor;
            HairColor = hairColor;
            Height = height;
            Weight = weight;
            Birthplace = birthplace;
            FavoriteColor = favoriteColor;
            Hobbies = hobbies;
            Skills = skills;
            Languages = languages;
            SocialMedia = socialMedia;
            Bio = bio;
        }
        //[DataMember]
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string BloodType { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Birthplace Birthplace { get; set; }
        public string FavoriteColor { get; set; }
        public string Hobbies { get; set; }
        public List<Skill> Skills { get; set; }
        public string Languages { get; set; }
        public string SocialMedia { get; set; }
        public string Bio { get; set; }

        public object Clone()
        {
            //return new Human
            //{
            //    Name = this.Name,
            //    Age = this.Age,
            //    Gender = this.Gender,
            //    Nationality = this.Nationality,
            //    Occupation = this.Occupation,
            //    Address = this.Address,
            //    PhoneNumber = this.PhoneNumber,
            //    Email = this.Email,
            //    Education = this.Education,
            //    MaritalStatus = this.MaritalStatus,
            //    Religion = this.Religion,
            //    BloodType = this.BloodType,
            //    EyeColor = this.EyeColor,
            //    HairColor = this.HairColor,
            //    Height = this.Height,
            //    Weight = this.Weight,
            //    Birthplace = this.Birthplace,
            //    FavoriteColor = this.FavoriteColor,
            //    Hobbies = this.Hobbies,
            //    Skills = this.Skills,
            //    Languages = this.Languages,
            //    SocialMedia = this.SocialMedia,
            //    Bio = this.Bio
            //};

            //or
            return MemberwiseClone();
        }
    }
}
