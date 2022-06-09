using System;

namespace ConsoleApp1.SendInput.Types
{
    // different input types used in the INPUT struct
    [Flags]
    public enum InputType
    {
        Mouse = 0,
        Keyboard = 1,
        Hardware = 2
    }
}