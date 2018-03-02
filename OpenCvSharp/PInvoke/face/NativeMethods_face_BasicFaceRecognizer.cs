﻿
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvHololens
{
    // ReSharper disable InconsistentNaming

    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern int face_BasicFaceRecognizer_getNumComponents(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_setNumComponents(IntPtr obj, int val);

        [DllImport(DllExtern)]
        public static extern double face_BasicFaceRecognizer_getThreshold(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_setThreshold(IntPtr obj, double val);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_getProjections(IntPtr obj, IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_getLabels(IntPtr obj, IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_getEigenValues(IntPtr obj, IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_getEigenVectors(IntPtr obj, IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void face_BasicFaceRecognizer_getMean(IntPtr obj, IntPtr dst);

        [DllImport(DllExtern)]
        public static extern IntPtr face_Ptr_BasicFaceRecognizer_get(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void face_Ptr_BasicFaceRecognizer_delete(IntPtr obj);
    }
}