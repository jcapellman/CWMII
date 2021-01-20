using CWMII.lib.Enums;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMII.UnitTests
{
    [TestClass]
    public class CWMIITests
    {
        [TestMethod]
        public void SerialNumber()
        {
            var result = Win32_BIOS.SerialNumber.GetWMIValue();
            
            Assert.IsNotNull(result);
            
            Assert.AreNotEqual(result, lib.CWMII.UNKNOWN_VALUE);
        }

        [TestMethod]
        public void ProcessorId()
        {
            var result = Win32_Processor.ProcessorId.GetWMIValue();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllWinBios()
        {
            var result = lib.CWMII.GetProperties<Win32_BIOS>();
            
            Assert.IsNotNull(result);
            
            Assert.IsTrue(result.Count == 31);
        }
    }
}