using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CylinderVolume;

namespace CylinderVolumeTests
{
    [TestClass]
    public class VolumeTest
    {
        [TestMethod]
        public void CylinderVolume_5and10_return785()
        {
            int r = 5;
            int h = 10;
            double expected = 785.398;

            Volume volume = new Volume();
            double actual = volume.VolumeCalculation(r, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
