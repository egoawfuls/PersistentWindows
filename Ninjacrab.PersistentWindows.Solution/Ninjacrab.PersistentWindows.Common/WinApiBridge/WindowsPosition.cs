﻿using System;
using System.Runtime.InteropServices;

namespace Ninjacrab.PersistentWindows.Common.WinApiBridge
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowsPosition
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int Left;
        public int Top;
        public int Width;
        public int Height;
        public int Flags;
    }

    // workaround LiteDB compatibility issue in RECT data structure
    public struct RECT2
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public int Height
        {
            get
            {
                return Bottom - Top;
            }
        }
        public int Width
        {
            get
            {
                return Right - Left;
            }
        }
    }
}
