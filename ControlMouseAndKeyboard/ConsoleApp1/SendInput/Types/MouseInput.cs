using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1.SendInput.Types
{

    // https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        // absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the dwFlags member
        public int X;
        public int Y;
        // If dwFlags contains MOUSEEVENTF_WHEEL or MOUSEEVENTF_HWHEEL, then mouseData specifies the amount of wheel movement
        // A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward
        // One wheel click is defined as WHEEL_DELTA which is 120
        public uint MouseData;
        public uint Flags;
        // timestamp of the input, if it is set to 0, then the system provides its own timestamp. dwExtraInfo is an additional value associated with the mouse event.
        // It is obtained using the GetMessageExtraInfo function
        public uint Time;
        public IntPtr ExtraInfo;
    }
}