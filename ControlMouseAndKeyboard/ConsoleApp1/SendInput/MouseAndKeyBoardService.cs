using System;
using System.Runtime.InteropServices;
using ConsoleApp1.SendInput.Types;

namespace ConsoleApp1.SendInput
{
    public class MouseAndKeyBoardService
    {
        // Tutorials
        // https://www.codeproject.com/Articles/5264831/How-to-Send-Inputs-using-Csharp

        public static void ClickLeftMouseButton()
        {
            var mouseLeftDown = CreateMouseInput(0, 0, MouseEvent.LeftDown);
            var mouseLeftUp   = CreateMouseInput(0, 0, MouseEvent.LeftUp);
            var inputs       = new[] {mouseLeftDown, mouseLeftUp};
            SendInput((uint) inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        // upper-left corner of display (x = 0, y = 0)
        // lower-right corner of display (x = 65535, y = 65535).
        // for pcs with more than 1 monitor, the method has to be modified (use MOUSEEVENTF_VIRTUALDESK flag)
        public static void MoveMouseToAbsoluteCoordinates(int x, int y)
        {
            var moveMouse = CreateMouseInput(x, y, MouseEvent.Move | MouseEvent.Absolute);
            var inputs    = new[] {moveMouse};
            SendInput((uint) inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public static void MoveMouseRelativeToCurrentPosition(int dx, int dy)
        {
            var moveMouse = CreateMouseInput(dx, dy, MouseEvent.Move);
            var inputs    = new[] {moveMouse};
            SendInput((uint) inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public static void MoveMouseDownAndRightAndReleaseLeftMouseButtonExample() // from https://www.codeproject.com/Articles/5264831/How-to-Send-Inputs-using-Csharp
        {
            var moveMouseAndMouseLeftDown = CreateMouseInput(100, 00, MouseEvent.Move | MouseEvent.LeftDown);
            var mouseLeftUp               = CreateMouseInput(100, 00, MouseEvent.LeftUp);
            var inputs                    = new[] {moveMouseAndMouseLeftDown, mouseLeftUp};
            SendInput((uint) inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public static void PressKeyboardKey(Key key)
        {
            var keyDown = CreateKeyboardInput((int) key, KeyboardEvent.KeyDown | KeyboardEvent.ScanCode);
            var keyUp   = CreateKeyboardInput((int) key, KeyboardEvent.KeyUp | KeyboardEvent.ScanCode);
            var inputs  = new[] {keyDown, keyUp};
            SendInput((uint) inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        private static Input CreateKeyboardInput(int keyScanCode, KeyboardEvent keyboardEvent)
        {
            return new Input
            {
                Type = (int) InputType.Keyboard,
                InputUnion = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        VirtualKeyCode = 0,
                        ScanCode       = (ushort) keyScanCode,
                        Flags          = (uint) (keyboardEvent),
                        ExtraInfo      = GetMessageExtraInfo()
                    }
                }
            };
        }

        private static Input CreateMouseInput(int x, int y, MouseEvent mouseEvent)
        {
            return new Input
            {
                Type = (int) InputType.Mouse,
                InputUnion = new InputUnion
                {
                    mi = new MouseInput
                    {
                        X         = x,
                        Y         = y,
                        Flags     = (uint) (mouseEvent),
                        ExtraInfo = GetMessageExtraInfo()
                    }
                }
            };
        }


        // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint numInputs, Input[] inputs, int size);

        // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getmessageextrainfo
        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();
    }
}