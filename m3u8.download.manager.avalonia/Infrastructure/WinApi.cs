﻿using System.Runtime.InteropServices;

namespace m3u8.download.manager
{
    /// <summary>
    /// 
    /// </summary>
    internal static class WinApi
    {
        [DllImport("user32.dll")] private static extern bool GetKeyboardState( byte[] lpKeyState );
        public static bool IsShiftButtonPushed()
        {
            const int VK_SHIFT  = 0x10;
            const int VK_LSHIFT = 0xA0;
            const int VK_RSHIFT = 0xA1;

            var keyState = new byte[ 256 ];
            if ( GetKeyboardState( keyState ) )
            {
                return (1 < keyState[ VK_SHIFT ] || 1 < keyState[ VK_LSHIFT ] || 1 < keyState[ VK_RSHIFT ]);
            }
            return (false);
        }
    }
}
