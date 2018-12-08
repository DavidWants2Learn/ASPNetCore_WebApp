using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {

            // Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            // Act
            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");
        
            // Assert
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            Assert.Inconclusive();
        }
    }
}
