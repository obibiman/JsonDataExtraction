using System.Collections.Generic;
using System.IO;
using DataExtract.Domain;
using DataExtract.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;

namespace DataExtract.UnitTest
{
    /// <summary>
    ///     MenuDataAccessTests
    /// </summary>
    [TestClass]
    public class MenuDataAccessTests
    {
        /// <summary>
        ///     GetMenuData_ReadsJson_ReturnsInteger
        /// </summary>
        [TestMethod]
        public void GetMenuData_ReadsJson_ReturnsInteger()
        {
            //arrange
            var reader =
                new StreamReader(@"C:\DevSource\DotNet\JsonDataExtract\DataExtract.UnitTest\DataSource\CodeTest.json");
            var serializer = new JsonSerializer();
            var menuDataList = (List<RootObject>) serializer.Deserialize(reader, typeof (List<RootObject>));

            var jsonFileSource = new Mock<IFileDataAccess>();
            jsonFileSource.Setup(m => m.GetDataList())
                .Returns(menuDataList);
            var menuParser = new Mock<IMenuParser>();
            menuParser.Setup(m => m.GetMenuData(menuDataList)).Returns(294);
            var testData = 294;

            ////act
            var expected = menuParser.Object.GetMenuData(menuDataList);
            ////assert
            Assert.AreEqual(expected, testData);
        }
    }
}