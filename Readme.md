<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617755/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4416)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyTileControl.cs](./CS/MyTileControl.cs) (VB: [MyTileControl.vb](./VB/MyTileControl.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to suppress TileControl default navigation logic, and obtain "Esc" key down?


<p>In the example, we created a TileControl descendant with a TileControlHandle descendant. We modified the TileControlHandler.OnKeyDown event to give a user the capability to decide when navigation logic of the tile control should be used and when should not. We added the TilleControl.ProcessKeyCommand event for more comfortable use of this approach from the form. </p><p>In the event of using ProcessKeyCommandEventArgs that contains the following arguments: KeyData, TileControl, and KeyCommandResult,</p><p>the KeyCommandResult allows setting the desired behavior of key down processing:</p><p>None - not handled, use the default navigation logic.</p><p>True - handled, TileControl.KeyDown will not fire.</p><p>False - handled,  TileControl.KeyDown will not fire.</p>

<br/>


