using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryControl
{
    public class FileDirectory
    {
        public void CheckDirectoryExists()
        {
            string strDirectory = "폴더 경로";
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(strDirectory);
            if (directoryInfo.Exists)
            {
                //있을 때   
            }
            else
            {
                //없을 때   
            }
        }
        public void CheckFileExists()
        {
            string strFile = "파일 경로";
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(strFile);
            if (fileInfo.Exists)
            {
                //있을 때   
            }
            else
            {
                //없을 때   
            }
        }
    }
}
