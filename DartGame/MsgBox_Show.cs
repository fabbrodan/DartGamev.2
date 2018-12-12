using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartGame
{
    public static class MsgBox_Show
    {
        public static void Show_Message(string msg)
        {
            MessageBox.Show(msg, "Dart Game", MessageBoxButtons.OK);
        }
    }
}
