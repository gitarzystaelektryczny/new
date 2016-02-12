using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Zadanie1Arek.PersonManager
{
    public class XMLSerializer
    {
        public static void Serialization(List<Person> list, string path)
        {
            XmlSerializer oSerializer = new XmlSerializer(typeof(List<Person>));
            StreamWriter sw = new StreamWriter(path);
            oSerializer.Serialize(sw, list);
            sw.Close();        
        }

        public static List<Person> Deserialization(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);
            var list = (List<Person>)serializer.Deserialize(reader);
            fs.Close();
                 
            return list;
        }
    }
}
