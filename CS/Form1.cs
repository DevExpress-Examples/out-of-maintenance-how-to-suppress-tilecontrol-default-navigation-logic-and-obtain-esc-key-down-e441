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
