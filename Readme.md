# How to suppress TileControl default navigation logic, and obtain "Esc" key down?


<p>In the example, we created a TileControl descendant with a TileControlHandle descendant. We modified the TileControlHandler.OnKeyDown event to give a user the capability to decide when navigation logic of the tile control should be used and when should not. We added the TilleControl.ProcessKeyCommand event for more comfortable use of this approach from the form. </p><p>In the event of using ProcessKeyCommandEventArgs that contains the following arguments: KeyData, TileControl, and KeyCommandResult,</p><p>the KeyCommandResult allows setting the desired behavior of key down processing:</p><p>None - not handled, use the default navigation logic.</p><p>True - handled, TileControl.KeyDown will not fire.</p><p>False - handled,  TileControl.KeyDown will not fire.</p>

<br/>


