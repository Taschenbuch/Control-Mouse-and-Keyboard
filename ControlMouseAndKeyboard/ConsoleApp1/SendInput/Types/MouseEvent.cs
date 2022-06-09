using System;

namespace ConsoleApp1.SendInput.Types
{
    //  flags used by the MouseInput struct.
    [Flags]
    public enum MouseEvent
    {
        Absolute = 0x8000,
        Move = 0x0001,
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        RightDown = 0x0008,
        RightUp = 0x0010,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        XDown = 0x0080, // An X button was pressed.
        XUp = 0x0100,   // An X button was released.
        HorizontalWheel = 0x1000,
        MoveNoCoalesce = 0x2000,
        VirtualDesk = 0x4000,
        Wheel = 0x0800,
    }
}