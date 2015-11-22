using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestME
{
    class Settings
    {

        public static void save(string filename, params string[] details)
        {
            if (!Directory.Exists(Globals.FilesPath + "\\TestME"))
            {
                Directory.CreateDirectory(Globals.FilesPath + "\\TestME");
            }
            // Write the string array to a new file. If file exists overwrite data.
            using (StreamWriter outputFile = new StreamWriter(Globals.FilesPath + "\\TestME\\" + filename, false))
            {
                foreach (string line in details)
                    outputFile.WriteLine(line);
            }
        }

        public static string[] load(string filename, int size)
        {
            string[] details = new string[size];
            // Open the text file using a stream reader.
            if (File.Exists(Globals.FilesPath + "\\TestME\\" + filename))
            {
                using (StreamReader file = new StreamReader(Globals.FilesPath + "\\TestME\\" + filename))
                {
                    // Read the stream to a string.
                    for (int i = 0; i < details.Length; i++)
                    {
                        details[i] = file.ReadLine();
                    }

                }
            }
            return details;
        }

        public static void delete(string filename)
        {
            if (File.Exists(Globals.FilesPath + "\\TestME\\"+filename))
            {
                File.Delete(Globals.FilesPath + "\\TestME\\"+filename);
            }
        }

    }
}
