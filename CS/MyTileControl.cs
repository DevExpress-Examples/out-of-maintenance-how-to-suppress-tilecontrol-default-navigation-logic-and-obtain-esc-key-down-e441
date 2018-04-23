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
