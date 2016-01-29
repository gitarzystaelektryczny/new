using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zadanie1Piotrek.PersonManager
{
    public class BinaryStream<T>
    {
        public static void BinarySerializer(string path, T obj)
        {
            if (obj != null)
            {
                using (FileStream streamSerial = new FileStream(path, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(streamSerial, obj);
                }
            }
        }

        public static T Deserialize(string path)
        {
            T temp = default(T);

            if (File.Exists(path))
            {
                using (FileStream streamDeserial = new FileStream(path, FileMode.Open))
                {
                    if (streamDeserial.Length > 0)
                    {
                        var bf = new BinaryFormatter();
                        return (T)bf.Deserialize(streamDeserial);
                    }
                }
            }
            return temp;
        }

    }
}
