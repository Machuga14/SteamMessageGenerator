using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SteamMessageGenerator
{
    public class Saver
    {
        string applicationName;
        string mainPath;

        List<string> DebugStringsList;

        public Saver(string applicationName)
        {
            this.DebugStringsList = new List<string>();

            this.applicationName = applicationName;
            this.mainPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Machuga14 Gaming Directory" + "\\" + this.applicationName + "\\";
            if (Directory.Exists(mainPath))
            {

            }
            else
            {
                Directory.CreateDirectory(mainPath);
            }
        }

        public void Save(string data, string FileName, string SubFolder)
        {
            if (!Directory.Exists(mainPath + SubFolder))
            {
                Directory.CreateDirectory(mainPath + SubFolder);
            }

            using (StreamWriter write = new StreamWriter(this.mainPath + SubFolder + FileName))
            {
                write.Write(data);
            }
        }

        public string Load(string FileName, string subfolder)
        {
            try
            {
                using (StreamReader read = new StreamReader(mainPath + subfolder + FileName))
                {
                    return read.ReadToEnd();
                }
            }
            catch
            {
                if (!Directory.Exists(mainPath + subfolder))
                {
                    Directory.CreateDirectory(mainPath + subfolder);
                }

                using (StreamWriter write = new StreamWriter(mainPath + subfolder + FileName))
                {
                    write.Write("");
                }
                return this.Load(FileName, subfolder);
            }
        }

        public List<string> LoadAsListOfString(string FileName, string subfolder)
        {
            try
            {
                List<string> retList = new List<string>();

                using (StreamReader read = new StreamReader(mainPath + subfolder + FileName))
                {
                    string nextLine = null;
                    while ((nextLine = read.ReadLine()) != null)
                    {
                        //nextLine = read.ReadLine();
                        retList.Add(nextLine);
                    }
                }
                return retList;
            }
            catch
            {
                if (!Directory.Exists(mainPath + subfolder))
                {
                    Directory.CreateDirectory(mainPath + subfolder);
                }

                using (StreamWriter write = new StreamWriter(mainPath + subfolder + FileName))
                {
                    write.Write("");
                }
                return this.LoadAsListOfString(FileName, subfolder);
            }
        }

        public void DebugSaving(string data)
        {
            this.DebugStringsList.Add(data);
            using (StreamWriter write = new StreamWriter(this.mainPath + "OveralDebugSaving.txt"))
            {
                for (int i = 0; i < this.DebugStringsList.Count(); i++)
                {
                    write.WriteLine(this.DebugStringsList[i]);
                }
            }
        }

        public string[] GetFolderNames()
        {
            string[] collectedSaves = Directory.GetDirectories(mainPath);
            List<string> retSaves = new List<String>();

            for (int i = 0; i < collectedSaves.Length; i++)
            {
                if (File.Exists(collectedSaves[i] + "\\GameData.dat"))
                {
                    collectedSaves[i] = this.RemovePriorDirectorys(collectedSaves[i]);
                    retSaves.Add(collectedSaves[i]);
                }
            }

            return retSaves.ToArray();
        }

        public void DeleteDirectory(string dir)
        {
            string[] currentFolders = this.GetFolderNames();

            for (int i = 0; i < currentFolders.Length; i++)
            {
                if (currentFolders[i] == dir)
                {
                    Directory.Delete(mainPath + dir, true);
                }
            }
        }

        private string RemovePriorDirectorys(string name)
        {
            for (int i = name.Length - 1; i >= 0; i--)
            {
                if (name[i] == '\\')
                    return name.Substring(i + 1);
            }
            return name;
        }

        public bool DoesDirectoryExist(string dir)
        {
            string[] currentFolders = this.GetFolderNames();
            if (currentFolders.Contains(dir))
                return true;
            return false;
        }

        public bool DoesFileExist(string name)
        {
            return File.Exists(mainPath + name);
        }

        public void MoveFileToFolder(string fileName, string folderName)
        {
            if (folderName == null)
            {
                File.Delete(mainPath + fileName);
                return;
            }
            if (!Directory.Exists(mainPath + folderName))
                Directory.CreateDirectory(mainPath + folderName);
            File.Copy(mainPath + fileName, mainPath + "\\" + folderName + "\\" + fileName);
            File.Delete(mainPath + fileName);
        }
    }
}
