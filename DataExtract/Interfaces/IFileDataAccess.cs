using System.Collections.Generic;
using DataExtract.Domain;

namespace DataExtract.Interfaces
{
    /// <summary>
    ///     IFileDataAccess
    /// </summary>
    public interface IFileDataAccess
    {
        List<RootObject> GetDataList();
    }
}