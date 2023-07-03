using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.views;

namespace INFSYS_Design
{
    static class Program
    {
        public static int currentUserId;
        public static string currentUserRole;
        public static List<Form> previousForm = new List<Form> { };
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Login());
        }
    }
}
