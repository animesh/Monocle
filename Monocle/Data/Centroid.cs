﻿using System;

namespace Monocle.Data
{
    /// <summary>
    /// for pulling spectral information from API scans
    /// </summary>
    public struct Centroid
    {
        public Centroid(double mz, double intensity)
        {
            Mz = mz;
            Intensity = intensity;
        }

        /// <summary>
        /// Centroid intensity
        /// </summary>
        public double Mz { get; set; }

        /// <summary>
        /// Centroid intensity
        /// </summary>
        public double Intensity { get; set; }

        /// <summary>
        /// Centroid intensity
        /// </summary>
        public double Noise { get; set; }
    }
}
