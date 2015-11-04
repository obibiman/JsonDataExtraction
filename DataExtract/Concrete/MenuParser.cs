using System;
using System.Collections.Generic;
using DataExtract.Domain;
using DataExtract.Interfaces;

namespace DataExtract.Concrete
{
    /// <summary>
    ///     MenuParser
    /// </summary>
    public class MenuParser : IMenuParser
    {
        /// <summary>
        ///     GetMenuData
        /// </summary>
        /// <param name="menuDataList"></param>
        /// <returns>int</returns>
        public int GetMenuData(IList<RootObject> menuDataList)
        {
            var total = 0;
            try
            {
                //var menuDataList = GetDataList();
                foreach (var item in menuDataList)
                {
                    foreach (var menuItem in item.menu.items)
                    {
                        if (menuItem?.label != null)
                        {
                            if (menuItem.label != string.Empty)
                            {
                                if (menuItem.id.HasValue)
                                    total = total + menuItem.id.Value;
                            }
                        }
                    }
                }
                return total;
            }
            catch (Exception exep)
            {
                Console.WriteLine(exep.Message);
            }
            return total;
        }
    }
}