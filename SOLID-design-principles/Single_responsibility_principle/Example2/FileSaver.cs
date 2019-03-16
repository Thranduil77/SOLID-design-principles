namespace Single_responsibility_principle.Example2
{
    #region Using

    using System.IO;

    #endregion

    public class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}