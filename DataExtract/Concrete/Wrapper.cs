using System.Configuration;
using System.IO;
using DataExtract.Interfaces;

namespace DataExtract.Concrete
{
    /// <summary>
    ///     Wrapper
    /// </summary>
    public class Wrapper : IWrapper
    {
        /// <summary>
        ///     Exists
        /// </summary>
        /// <param name="path"></param>
        /// <returns>bool</returns>
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        ///     GetFilePath
        /// </summary>
        /// <returns>string</returns>
        public string GetFilePath()
        {
            return Directory.GetCurrentDirectory() + "\\" + ConfigurationManager.AppSettings["JsonSource"];
        }
    }
}