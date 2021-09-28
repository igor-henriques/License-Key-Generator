using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace License_Key_Generator
{
    public class AnimatedCurs
    {
        [DllImport("User32.dll")]
        private static extern IntPtr LoadCursorFromFile(String str);

        public static Cursor Create(string fname)
        {
            IntPtr HC = LoadCursorFromFile(fname);

            if (!IntPtr.Zero.Equals(HC))
            {
                return new Cursor(HC);
            }
            else
            {
                throw new ApplicationException("CURSOR ERROR: " + fname);
            }
        }
    }
}