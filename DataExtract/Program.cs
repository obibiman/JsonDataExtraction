using DataExtract.Concrete;
using DataExtract.Interfaces;
using Microsoft.Practices.Unity;
using static System.Console;

namespace DataExtract
{
    /// <summary>
    ///     Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     Main
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var container = new UnityContainer();
            //container.RegisterType<IJsonFileSource, JsonFileSource>();
            container.RegisterType<IMenuParser, MenuParser>();
            container.RegisterType<IFileDataAccess, FileDataAccess>();
            container.RegisterType<IWrapper, Wrapper>();
            container.Resolve<Wrapper>();
            var dataList = container.Resolve<FileDataAccess>();
            var mdaa = container.Resolve<MenuParser>();

            //container.Resolve<JsonFileSource>();
            var sumId = mdaa.GetMenuData(dataList.GetDataList());
            WriteLine($"The sum of the ids with non null label values is {sumId}");
            ReadKey();
        }
    }
}