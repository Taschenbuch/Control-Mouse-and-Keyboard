using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ConsoleApp1.SendInput;
using ConsoleApp1.SendInput.Types;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(4 * 1000);

            // works in broken age (opens new game tab, then moves mouse down and opens load game tab // uncomment to try example
            //MouseAndKeyBoardService.LeftClickMouse();
            //Thread.Sleep(1000);
            //MouseAndKeyBoardService.MoveMouseRelativeToCurrentPosition(0, 20);
            //Thread.Sleep(1000);
            //MouseAndKeyBoardService.LeftClickMouse();

            // works in broken age // uncomment to try example
            //MouseAndKeyBoardService.MoveMouseRelativeToCurrentPosition(10, 20); 

            // works in broken age // uncomment to try example
            //MouseAndKeyBoardService.PressKeyboardKey(Key.Q); 

            // NOT working in broken age // uncomment to try example
            //MouseAndKeyBoardService.MoveMouseToAbsoluteCoordinates(1000, 1000); 
            //MouseAndKeyBoardService.MoveMouseToAbsoluteCoordinates(65535, 65535); // lower-right corner
            //MouseAndKeyBoardService.MoveMouseToAbsoluteCoordinates(0, 0); // upper-left corner

            // example code from web // uncomment to try example
            //MouseAndKeyBoardService.MoveMouseDownAndRightAndReleaseLeftMouseButtonExample(); 
        }
    }
}
