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
