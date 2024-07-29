using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

namespace _009_ICloneable
{
    //for more as Senior+  https://medium.com/@dayanandthombare/object-cloning-in-c-a-comprehensive-guide-%EF%B8%8F-%EF%B8%8F-d3b79ed6ebcd
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CloneBenchmarker>();

            //CloneBenchmarker benchmarker = new CloneBenchmarker();
            //benchmarker.TotalCount = 1;
            //benchmarker.DeepCopyXML();
        }
    }
    [MemoryDiagnoser]
    public class CloneBenchmarker
    {
        [Params(1000, 10000)]
        public int TotalCount;

        Human original = new Human(
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

        [Benchmark]
        public void IClonableCopy()
        {
            for (int i = 0; i < TotalCount; i++)
            {
                var clone1 = (Human)original.Clone();
            }
        }

        [Benchmark]
        public void DeepCopyXML()
        {
            for (int i = 0; i < TotalCount; i++)
            {
                using var stream = new MemoryStream();

                var serializer = new XmlSerializer(typeof(Human));
                serializer.Serialize(stream, original);
                stream.Position = 0;
                var clone = (Human)serializer.Deserialize(stream);
            }
        }

        [Benchmark]
        public void DeepCopyJSON()
        {
            for (int i = 0; i < TotalCount; i++)
            {
                var jsonString = JsonSerializer.Serialize(original);
                var clone = JsonSerializer.Deserialize<Human>(jsonString);
            }
        }

        [Benchmark]
        public void DeepCopyDataContract()
        {
            for (int i = 0; i < TotalCount; i++)
            {
                using var stream = new MemoryStream();

                var serializer = new DataContractSerializer(typeof(Human));
                serializer.WriteObject(stream, original);
                stream.Position = 0;
                var clone = (Human)serializer.ReadObject(stream);
            }
        }

        [Benchmark]
        public void DeepCopyReflection()
        {
            for (int i = 0; i < TotalCount; i++)
            {
                var clone = DeepCopyReflection(original);
            }
        }

        private Human DeepCopyReflection<Human>(Human input)
        {
            var type = input.GetType();
            var properties = type.GetProperties();
            Human clonedObj = (Human)Activator.CreateInstance(type);
            foreach (var property in properties)
            {
                if (property.CanWrite)
                {
                    object value = property.GetValue(input);
                    if (value != null && value.GetType().IsClass && !value.GetType().FullName.StartsWith("System."))
                    {
                        property.SetValue(clonedObj, DeepCopyReflection(value));
                    }
                    else
                    {
                        property.SetValue(clonedObj, value);
                    }
                }
            }
            return clonedObj;
        }
    }
}
