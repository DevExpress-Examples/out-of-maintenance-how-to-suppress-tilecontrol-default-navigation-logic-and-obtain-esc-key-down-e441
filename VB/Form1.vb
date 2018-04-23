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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TileControlSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			SubscribeEvents()
		End Sub
		Private Sub SubscribeEvents()
			AddHandler tileControl1.ProcessKeyCommand, AddressOf OnTileControlProcessKeyCommand
		End Sub
		Private Sub UnSubscribeEvents()
			RemoveHandler tileControl1.ProcessKeyCommand, AddressOf OnTileControlProcessKeyCommand
		End Sub

		Private Sub OnTileControlProcessKeyCommand(ByVal sender As Object, ByVal e As ProcessKeyCommandEventArgs)
			If e.KeyData = Keys.Escape AndAlso e.TileControl.ShouldProcessEsc Then
				System.Diagnostics.Debug.Print("Escape Processed !!")
				e.Result = KeyCommandResult.True
				Return
			End If
			e.Result = KeyCommandResult.None
		End Sub

		#Region "Disposing"
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			UnSubscribeEvents()
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region
	End Class
End Namespace
