﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern void ximgproc_niBlackThreshold(
            IntPtr src, IntPtr dst, double maxValue, int type,
            int blockSize, double delta);

        [DllImport(DllExtern)]
        public static extern void ximgproc_thinning(IntPtr src, IntPtr dst, int thinningType);

        [DllImport(DllExtern)]
        public static extern void ximgproc_weightedMedianFilter(
            IntPtr joint, IntPtr src, IntPtr dst,
            int r, double sigma, int weightType, IntPtr mask);

        [DllImport(DllExtern)]
        public static extern void ximgproc_covarianceEstimation(
            IntPtr src, IntPtr dst, int windowRows, int windowCols);
    }
}