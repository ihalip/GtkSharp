// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

	public delegate void ValueChangedHandler(object o, ValueChangedArgs args);

	public class ValueChangedArgs : GLib.SignalArgs {
		public double P0{
			get {
				return (double) Args [0];
			}
		}

		public string P1{
			get {
				return (string) Args [1];
			}
		}

	}
}