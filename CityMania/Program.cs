using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mogre;
using MogreFramework;

namespace Test
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            OgreWindow win = new OgreWindow();

            try
            {
                win.Go();
            }
            catch (System.Runtime.InteropServices.SEHException)
            {
                if (OgreException.IsThrown)
                    MessageBox.Show(OgreException.LastException.FullDescription,
                                    "An Ogre exception has occurred!");
                else
                    throw;
            }
        }
    }
}
