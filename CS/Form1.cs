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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileControlSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            SubscribeEvents();
        }
        void SubscribeEvents() {
            tileControl1.ProcessKeyCommand += OnTileControlProcessKeyCommand;
        }
        void UnSubscribeEvents() {
            tileControl1.ProcessKeyCommand -= OnTileControlProcessKeyCommand;
        }
        
        void OnTileControlProcessKeyCommand(object sender, ProcessKeyCommandEventArgs e) {
            if(e.KeyData == Keys.Escape && e.TileControl.ShouldProcessEsc) {
                System.Diagnostics.Debug.Print("Escape Processed !!");
                e.Result = KeyCommandResult.True;
                return;
            }
            e.Result = KeyCommandResult.None;
        }

        #region Disposing
        protected override void Dispose(bool disposing) {
            UnSubscribeEvents();
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
