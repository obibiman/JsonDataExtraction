using System.Collections.Generic;
using System.IO;
using DataExtract.Domain;
using DataExtract.Interfaces;
using Newtonsoft.Json;

namespace DataExtract.Concrete
{
    /// <summary>
    ///     File data access
    /// </summary>
    public class FileDataAccess : IFileDataAccess
    {
        private readonly IWrapper _wrapper;

        /// <summary>
        ///     FileDataAccess
        /// </summary>
        /// <param name="wrapper"></param>
        public FileDataAccess(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        /// <summary>
        ///     GetDataList
        /// </summary>
        /// <returns>List<RootObject></RootObject></returns>
        public List<RootObject> GetDataList()
        {
            var menuDataList = new List<RootObject>();

            if (_wrapper.Exists(_wrapper.GetFilePath()))
            {
                using (var reader = File.OpenText(_wrapper.GetFilePath()))
                {
                    var serializer = new JsonSerializer();
                    menuDataList = (List<RootObject>) serializer.Deserialize(reader, typeof (List<RootObject>));
                }
            }
            return menuDataList;
        }
    }
}