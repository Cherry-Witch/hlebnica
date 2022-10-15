using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace oop1.Library
{
    static public class LibraryParser
    {
        static public void SaveLibrary(Library library)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Library));

            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, library);

                Console.WriteLine("Библеотека была сохранена.");
            }
        }

        static public Library LoadLibrary()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Library));

            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                Library library = xmlSerializer.Deserialize(fs) as Library;

                return library;
            }
        }

    }
}
