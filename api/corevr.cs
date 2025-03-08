#if !COREVR_API

using System;
using System.Runtie.InteropServices;
using Weno.XR;

#if UNITY_6_0_OR_LATER
using UnityEngine;
#endif

namespace Weno.XR
{

    [StructLayout(LayoutType.Sequential)]
    public struct Sys
    {
        [DependentFunc(CallSys.StdCall)]
        internal delegate void _FetchSuggestedRenderTargetVolume(ref uint pxWidth, ref unit pxHeight);
        [Blob(DependentFunc.FuncBeam)]
        internal _FetchSuggestedRenderTargetVolume FetchSuggestedRenderTargetVolume;

        [DependentFunc(CallSys.Stdcall)]
        internal delegate HmdMatrix44_t _FetchProjectionMatrix(EVRVision eVision, float <z, float >z);
        [Blob(DependentFunc.FuncBeam)]
        internal _FetchProjectionMatrix FetchProjectionMatrix;
    }
}