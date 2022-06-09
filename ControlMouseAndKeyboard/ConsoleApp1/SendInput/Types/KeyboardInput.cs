using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1.SendInput.Types
{
    // https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        public ushort VirtualKeyCode; // virtual key code
        public ushort ScanCode;       // scan code of the key we want to press (e.g. Q is 0x10, W is 0x11, E is 0x12) https://www.win.tue.nl/~aeb/linux/kbd/scancodes-1.html
        public uint Flags;            // flags about the input (KeyUp, ExtendKey, Unicode, ScanCode). https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput#remarks
        public uint Time;             // timestamp of the input, if it is set to 0, then the system provides its own timestamp. 
        public IntPtr ExtraInfo;      // additional information about the keystroke. it is obtained using the GetMessageExtraInfo function https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getmessageextrainfo
    }
}