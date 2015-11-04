using System.Collections.Generic;
using DataExtract.Domain;

namespace DataExtract.Interfaces
{
    /// <summary>
    ///     IMenuParser
    /// </summary>
    public interface IMenuParser
    {
        int GetMenuData(IList<RootObject> menuDataList);
    }
}