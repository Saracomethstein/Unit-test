using System;

namespace CylinderVolume
{
    public class Volume
    {
        public double VolumeCalculation(int r, int h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 3);
        }
    }
}
