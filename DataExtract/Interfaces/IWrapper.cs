namespace DataExtract.Interfaces
{
    /// <summary>
    ///     IWrapper
    /// </summary>
    public interface IWrapper
    {
        bool Exists(string path);
        string GetFilePath();
    }
}