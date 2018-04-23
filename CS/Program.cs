// Developer Express Code Central Example:
// How to suppress TileControl default navigation logic, and obtain "Esc" key down?
// 
// In the example, we created a TileControl descendant with a TileControlHandle
// descendant. We modified the TileControlHandler.OnKeyDown event to give a user
// the capability to decide when navigation logic of the tile control should be
// used and when should not. We added the TilleControl.ProcessKeyCommand event for
// more comfortable use of this approach from the form. In the event of using
// ProcessKeyCommandEventArgs that contains the following arguments: KeyData,
// TileControl, and KeyCommandResult,
// the KeyCommandResult allows setting the
// desired behavior of key down processing:
// None - not handled, use the default
// navigation logic.
// True - handled, TileControl.KeyDown will not fire.
// False -
// handled, TileControl.KeyDown will not fire.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TileControlSample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
