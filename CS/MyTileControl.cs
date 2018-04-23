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
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace TileControlSample {
    public class MyTileControl : TileControl {
        public MyTileControl() {
            ShouldProcessEsc = true;
        }
        public bool ShouldProcessEsc {
            get;
            set;
        }
        protected override TileControlHandler CreateHandler() {
            return new MyTileControlHandler(this);
        }
        public event EventHandler<ProcessKeyCommandEventArgs> ProcessKeyCommand;
        protected internal void RaiseProcessKeyCommand(ProcessKeyCommandEventArgs e) {
            if(ProcessKeyCommand != null)
                ProcessKeyCommand(this, e);
        }
    }
    public class MyTileControlHandler : TileControlHandler {
        public MyTileControlHandler(ITileControl control)
            : base(control) {
        }
        protected override bool OnKeyDownCore(Keys keyData) {
            ProcessKeyCommandEventArgs e = new ProcessKeyCommandEventArgs(MyTileControl, keyData);
            MyTileControl.RaiseProcessKeyCommand(e);
            if(e.Result == KeyCommandResult.None)
                return base.OnKeyDownCore(keyData);
            return e.Result == KeyCommandResult.True ? true : false;
        }
        
        MyTileControl MyTileControl { get { return Control as MyTileControl; } }
    }

    public enum KeyCommandResult {
        True, False, None
    }

    public class ProcessKeyCommandEventArgs : EventArgs {
        public ProcessKeyCommandEventArgs(MyTileControl tileControl, Keys keyData) {
            this.Result = KeyCommandResult.None;
            this.KeyData = keyData;
            this.TileControl = tileControl;
        }
        public Keys KeyData { get; private set; }
        public KeyCommandResult Result { get; set; }
        public MyTileControl TileControl { get; private set; }
    }
}
