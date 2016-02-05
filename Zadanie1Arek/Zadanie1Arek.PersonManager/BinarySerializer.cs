﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zadanie1Arek.PersonManager
{
    public class Serializators<T> 
    {
        public static void BinarySerializer (string path, T obj)
        {
            if(obj != null)
            {
                using (var fs = new FileStream(path, FileMode.Create))
                {
                    var bf = new BinaryFormatter();
                    bf.Serialize(fs, obj);
                }
            }
        }

        public static T Deserialize (string path)
        {
            T temp = default(T);

            if(File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    if(fs.Length > 0)
                    {
                        var bf = new BinaryFormatter();
                        return (T)bf.Deserialize(fs);
                    }
                }
            }
            return temp;
        }

    }
}
