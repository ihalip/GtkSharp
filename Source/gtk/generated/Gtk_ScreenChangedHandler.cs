// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ScreenChangedHandler(object o, ScreenChangedArgs args);

	public class ScreenChangedArgs : GLib.SignalArgs {
		public Gdk.Screen PreviousScreen{
			get {
				return (Gdk.Screen) Args [0];
			}
		}

	}
}