using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mscoree
{
  [CompilerGenerated]
  [Guid("CB2F6722-AB3A-11D2-9C40-00C04FA30A3E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  [CLSCompliant(false)]
  public interface ICorRuntimeHost
  {
    void _VtblGap1_11();

    void EnumDomains(out IntPtr enumHandle);

    void NextDomain([In] IntPtr enumHandle, [MarshalAs(UnmanagedType.IUnknown)] out object appDomain);

    void CloseEnum([In] IntPtr enumHandle);
  }
}