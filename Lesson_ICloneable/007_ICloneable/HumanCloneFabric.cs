using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

namespace _007_ICloneable
{
    internal class HumanCloneFabric
    {
        public static Human DeepCopyXML<Human>(Human input)
        {
            using var stream = new MemoryStream();

            var serializer = new XmlSerializer(typeof(Human));
            serializer.Serialize(stream, input);
            stream.Position = 0;
            return (Human)serializer.Deserialize(stream);
        }
        public static Human DeepCopyJSON<Human>(Human input)
        {
            var jsonString = JsonSerializer.Serialize(input);
            return JsonSerializer.Deserialize<Human>(jsonString);
        }
        public static Human DeepCopyDataContract<Human>(Human input)
        {
            using var stream = new MemoryStream();

            var serializer = new DataContractSerializer(typeof(Human));
            serializer.WriteObject(stream, input);
            stream.Position = 0;

            return (Human)serializer.ReadObject(stream);
        }

        public static T DeepCopyReflection<T>(T input)
        {
            var type = input.GetType();
            var properties = type.GetProperties();
            T clonedObj = (T)Activator.CreateInstance(type);
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
