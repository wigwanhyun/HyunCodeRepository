using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryControl
{
    public class FileDirectory
    {
        public static List<string> GetDirectoryFileList(string directory)
        {
            if (Directory.Exists(directory))
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                List<string> fileNames = new List<string>();
                foreach (var file in di.GetFiles())
                {
                    fileNames.Add(file.Name);
                }
                return fileNames;
            }
            else
            {
                return null;
            }
        }
        public static List<string> GetDirectoryFileList(string directory, string filter)
        {
            if (Directory.Exists(directory))
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                List<string> fileNames = new List<string>();
                foreach (var file in di.GetFiles(filter))
                {
                    fileNames.Add(file.Name);
                }
                return fileNames;
            }
            else
            {
                return null;
            }
        }
        public static bool IsFileExists(string file)
        {
            if (File.Exists(file))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetFileContent(string file)
        {
            return File.ReadAllText(file);
        }
        public static void DeleteFile(string file)
        {
            try
            {
                File.Delete(file);
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }
        public static void CreateDirecotry(string directory)
        {
            Directory.CreateDirectory(directory);
        }
        public static bool IsDirectoryExists(string directory)
        {
            if (Directory.Exists(directory))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool IsFileLocked(string file)
        {
            try
            {
                using (File.Open(file, FileMode.Open)) { }
            }
            catch (IOException e)
            {
                var errorCode = Marshal.GetHRForException(e) & ((1 << 16) - 1);
                if (errorCode == 32 || errorCode == 33)
                {
                    return true;
                }
                return false;
            }

            return false;
        }


        public static void MoveFile(string srcDirectory, string dstDirectory)
        {
            File.Copy(srcDirectory, dstDirectory, true);
        }


        public void Archive(string archiveFileDirectory, string archivedDirectoryFileName, string filter)
        {
            if (GetDirectoryFileList(archiveFileDirectory, filter).Count == 0)
            {
                return;
            }
            using (FileStream zipToOpen = new FileStream($"{archivedDirectoryFileName}.zip", FileMode.CreateNew))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                {
                    foreach (var filePath in Directory.EnumerateFiles(archiveFileDirectory, filter))
                    {
                        ZipFileExtensions.CreateEntryFromFile(archive, filePath, filePath.Substring(filePath.LastIndexOf("/")));
                        DeleteFile(filePath);
                    }
                }
            }
        }
    }
}
