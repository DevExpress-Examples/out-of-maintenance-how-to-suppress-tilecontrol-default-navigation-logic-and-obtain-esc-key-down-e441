Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace TileControlSample
	Public Class MyTileControl
		Inherits TileControl
		Public Sub New()
			ShouldProcessEsc = True
		End Sub
		Private privateShouldProcessEsc As Boolean
		Public Property ShouldProcessEsc() As Boolean
			Get
				Return privateShouldProcessEsc
			End Get
			Set(ByVal value As Boolean)
				privateShouldProcessEsc = value
			End Set
		End Property
		Protected Overrides Function CreateHandler() As TileControlHandler
			Return New MyTileControlHandler(Me)
		End Function
		Public Event ProcessKeyCommand As EventHandler(Of ProcessKeyCommandEventArgs)
		Protected Friend Sub RaiseProcessKeyCommand(ByVal e As ProcessKeyCommandEventArgs)
			RaiseEvent ProcessKeyCommand(Me, e)
		End Sub
	End Class
	Public Class MyTileControlHandler
		Inherits TileControlHandler
		Public Sub New(ByVal control As ITileControl)
			MyBase.New(control)
		End Sub
		Protected Overrides Function OnKeyDownCore(ByVal keyData As Keys) As Boolean
			Dim e As New ProcessKeyCommandEventArgs(MyTileControl, keyData)
			MyTileControl.RaiseProcessKeyCommand(e)
			If e.Result = KeyCommandResult.None Then
				Return MyBase.OnKeyDownCore(keyData)
			End If
			Return If(e.Result = KeyCommandResult.True, True, False)
		End Function

		Private ReadOnly Property MyTileControl() As MyTileControl
			Get
				Return TryCast(Control, MyTileControl)
			End Get
		End Property
	End Class

	Public Enum KeyCommandResult
		[True]
		[False]
		None
	End Enum

	Public Class ProcessKeyCommandEventArgs
		Inherits EventArgs
		Public Sub New(ByVal tileControl As MyTileControl, ByVal keyData As Keys)
			Me.Result = KeyCommandResult.None
			Me.KeyData = keyData
			Me.TileControl = tileControl
		End Sub
		Private privateKeyData As Keys
		Public Property KeyData() As Keys
			Get
				Return privateKeyData
			End Get
			Private Set(ByVal value As Keys)
				privateKeyData = value
			End Set
		End Property
		Private privateResult As KeyCommandResult
		Public Property Result() As KeyCommandResult
			Get
				Return privateResult
			End Get
			Set(ByVal value As KeyCommandResult)
				privateResult = value
			End Set
		End Property
		Private privateTileControl As MyTileControl
		Public Property TileControl() As MyTileControl
			Get
				Return privateTileControl
			End Get
			Private Set(ByVal value As MyTileControl)
				privateTileControl = value
			End Set
		End Property
	End Class
End Namespace
