using System;

namespace ConsoleApp1.SendInput.Types
{
    //  flags used by the KeyboardInput struct
    [Flags]
    public enum KeyboardEvent
    {
        KeyDown = 0x0000,
        ExtendedKey = 0x0001,
        KeyUp = 0x0002,
        Unicode = 0x0004,
        ScanCode = 0x0008
    }
}