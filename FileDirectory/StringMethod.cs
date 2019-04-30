using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    class StringMethod
    {
        //public object Translate(string fileName)
        //{
        //    EloiLogger.Info("Entry");
        //    EloiLogger.Debug($"Param : {fileName}");
        //    if (!FileManager.IsFileExists(fileName))
        //    {
        //        EloiLogger.Debug($"{fileName} 파일 처리가 이미 되었거나 없는 파일입니다.");
        //        return null;
        //    }
        //    while (FileManager.IsFileLocked(fileName)) ;

        //    string fileContent = FileManager.GetFileContent(fileName);
        //    string typeName = fileName.Split('-')[0].Substring(fileName.LastIndexOf("/") + 1);

        //    Type type = Assembly.GetExecutingAssembly().GetType($"NxP.Console.FsiDataWatcher.Model.{typeName}");

        //    object targetClass = Activator.CreateInstance(type);

        //    object[] deserializeParam = new string[] { fileContent };
        //    object fctiJsonModel = type.GetMethod("Deserialize").Invoke(targetClass, deserializeParam);

        //    object[] translateParam = new object[] { fctiJsonModel };
        //    object fctiDbModel = type.GetMethod("Translate").Invoke(targetClass, translateParam);

        //    EloiLogger.Info("Terminate");
        //    return fctiDbModel;
        //}
    }
}
