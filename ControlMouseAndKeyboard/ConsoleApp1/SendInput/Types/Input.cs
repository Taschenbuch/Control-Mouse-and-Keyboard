namespace ConsoleApp1.SendInput.Types
{
    public struct Input
    {
        public int Type;              // type of the input event. It specifies which input struct will be used from the union: 1 for MOUSEINPUT, 2 for KEYBDINPUT, 3 for HARDWAREINPUT
        public InputUnion InputUnion; // contains the input data for the mouse, keyboard, or hardware
    }
}