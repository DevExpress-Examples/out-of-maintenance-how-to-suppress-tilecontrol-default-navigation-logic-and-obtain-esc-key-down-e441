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
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("TileControlSample")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("TileControlSample")>
<Assembly: AssemblyCopyright("Copyright ©  2012")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("8201d86a-ec5e-44b7-abee-d0d219a11d75")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
