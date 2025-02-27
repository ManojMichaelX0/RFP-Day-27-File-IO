﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day27FileOperations
{
    public class BinarySerialization
    {

        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\.net\Day27FileOperations\Day27FileOperations\BinarySerialization.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            fileStream.Close();
        }
        public void DeSerializtion()
        {
            FileStream fileStream = new FileStream(@"D:\.net\Day27FileOperations\Day27FileOperations\BinarySerialization.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deseialisedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deseialisedSampleDemo.ApplicationName} --- ApplicationID {deseialisedSampleDemo.ApplicationId}");
            fileStream.Close();
            Console.ReadKey();

        }

        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; } = "Binary Serailization";
            public int ApplicationId { get; set; } = 1001;
        }
    }
}
