// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooRectangle : IEquatable<FooRectangle> {

		public int X;
		public int Y;
		public int Width;
		public int Height;

		public static Regress.FooRectangle Zero = new Regress.FooRectangle ();

		public static Regress.FooRectangle New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooRectangle.Zero;
			return (Regress.FooRectangle) Marshal.PtrToStructure (raw, typeof (Regress.FooRectangle));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_rectangle_add(IntPtr raw, IntPtr r2);

		public void Add(Regress.FooRectangle r2) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_r2 = GLib.Marshaller.StructureToPtrAlloc (r2);
			regress_foo_rectangle_add(this_as_native, native_r2);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_r2);
		}

		static void ReadNative (IntPtr native, ref Regress.FooRectangle target)
		{
			target = New (native);
		}

		public bool Equals (FooRectangle other)
		{
			return true && X.Equals (other.X) && Y.Equals (other.Y) && Width.Equals (other.Width) && Height.Equals (other.Height);
		}

		public override bool Equals (object other)
		{
			return other is FooRectangle && Equals ((FooRectangle) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ Width.GetHashCode () ^ Height.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}