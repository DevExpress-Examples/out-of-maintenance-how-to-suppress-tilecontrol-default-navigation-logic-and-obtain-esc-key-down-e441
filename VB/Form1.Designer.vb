Imports Microsoft.VisualBasic
Imports System
Namespace TileControlSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
			Me.tileControl1 = New MyTileControl()
			Me.tileGroup1 = New DevExpress.XtraEditors.TileGroup()
			Me.tileItem1 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem2 = New DevExpress.XtraEditors.TileItem()
			Me.tileGroup2 = New DevExpress.XtraEditors.TileGroup()
			Me.tileItem3 = New DevExpress.XtraEditors.TileItem()
			Me.SuspendLayout()
			' 
			' tileControl1
			' 
			Me.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tileControl1.Groups.Add(Me.tileGroup1)
			Me.tileControl1.Groups.Add(Me.tileGroup2)
			Me.tileControl1.Location = New System.Drawing.Point(0, 0)
			Me.tileControl1.Name = "tileControl1"
			Me.tileControl1.Size = New System.Drawing.Size(678, 320)
			Me.tileControl1.TabIndex = 0
			Me.tileControl1.Text = "tileControl1"
			' 
			' tileGroup1
			' 
			Me.tileGroup1.Items.Add(Me.tileItem1)
			Me.tileGroup1.Items.Add(Me.tileItem2)
			Me.tileGroup1.Name = "tileGroup1"
			Me.tileGroup1.Text = "tileGroup1"
			' 
			' tileItem1
			' 
			tileItemElement1.Text = "tileItem1"
			Me.tileItem1.Elements.Add(tileItemElement1)
			Me.tileItem1.Name = "tileItem1"
			' 
			' tileItem2
			' 
			tileItemElement2.Text = "tileItem2"
			Me.tileItem2.Elements.Add(tileItemElement2)
			Me.tileItem2.Name = "tileItem2"
			' 
			' tileGroup2
			' 
			Me.tileGroup2.Items.Add(Me.tileItem3)
			Me.tileGroup2.Name = "tileGroup2"
			Me.tileGroup2.Text = "tileGroup2"
			' 
			' tileItem3
			' 
			tileItemElement3.Text = "tileItem3"
			Me.tileItem3.Elements.Add(tileItemElement3)
			Me.tileItem3.Name = "tileItem3"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(678, 320)
			Me.Controls.Add(Me.tileControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tileControl1 As MyTileControl
		Private tileGroup1 As DevExpress.XtraEditors.TileGroup
		Private tileItem1 As DevExpress.XtraEditors.TileItem
		Private tileItem2 As DevExpress.XtraEditors.TileItem
		Private tileGroup2 As DevExpress.XtraEditors.TileGroup
		Private tileItem3 As DevExpress.XtraEditors.TileItem
	End Class
End Namespace

