' Developer Express Code Central Example:
' How to suppress TileControl default navigation logic, and obtain "Esc" key down?
' 
' In the example, we created a TileControl descendant with a TileControlHandle
' descendant. We modified the TileControlHandler.OnKeyDown event to give a user
' the capability to decide when navigation logic of the tile control should be
' used and when should not. We added the TilleControl.ProcessKeyCommand event for
' more comfortable use of this approach from the form. In the event of using
' ProcessKeyCommandEventArgs that contains the following arguments: KeyData,
' TileControl, and KeyCommandResult,
' the KeyCommandResult allows setting the
' desired behavior of key down processing:
' None - not handled, use the default
' navigation logic.
' True - handled, TileControl.KeyDown will not fire.
' False -
' handled, TileControl.KeyDown will not fire.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4416


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
		Public Property ShouldProcessEsc() As Boolean
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
		Public Property KeyData() As Keys
		Public Property Result() As KeyCommandResult
		Public Property TileControl() As MyTileControl
	End Class
End Namespace
