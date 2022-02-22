using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static SerializationDemo.BinarySerialization;

namespace SerializationDemo
{
        class BinaryDeSerialization
        {
            public void DeSerialization()
            {
                 FileStream fileStream = new FileStream(@"C:\Users\suraj\source\repos\FileIO\SerializationDemo\Example1.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
                Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
                Console.ReadKey();
            }
        }

}
