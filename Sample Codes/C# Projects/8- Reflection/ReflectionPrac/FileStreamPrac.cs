using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReflectionPrac
{
    class FileStreamPrac
    {
        public String ReadFile(String path)
        {
            FileStream fstream = File.Create(path);
            
            FileStream stream = new FileStream(path, FileMode.Open);

            StreamReader reader = new StreamReader(path);
            reader.ReadToEnd();

            return "";
        }
    }
}
