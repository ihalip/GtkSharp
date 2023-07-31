// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GlyphString : GLib.Opaque {

		public int NumGlyphs {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("num_glyphs"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("num_glyphs"));
					*raw_ptr = value;
				}
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_glyph_string_copy(IntPtr raw);

		public Pango.GlyphString Copy() {
			IntPtr raw_ret = pango_glyph_string_copy(Handle);
			Pango.GlyphString ret = raw_ret == IntPtr.Zero ? null : (Pango.GlyphString) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.GlyphString), true);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_extents(IntPtr raw, IntPtr font, IntPtr ink_rect, IntPtr logical_rect);

		public void Extents(Pango.Font font, Pango.Rectangle ink_rect, Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = GLib.Marshaller.StructureToPtrAlloc (ink_rect);
			IntPtr native_logical_rect = GLib.Marshaller.StructureToPtrAlloc (logical_rect);
			pango_glyph_string_extents(Handle, font == null ? IntPtr.Zero : font.Handle, native_ink_rect, native_logical_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_extents_range(IntPtr raw, int start, int end, IntPtr font, IntPtr ink_rect, IntPtr logical_rect);

		public void ExtentsRange(int start, int end, Pango.Font font, Pango.Rectangle ink_rect, Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = GLib.Marshaller.StructureToPtrAlloc (ink_rect);
			IntPtr native_logical_rect = GLib.Marshaller.StructureToPtrAlloc (logical_rect);
			pango_glyph_string_extents_range(Handle, start, end, font == null ? IntPtr.Zero : font.Handle, native_ink_rect, native_logical_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_get_logical_widths(IntPtr raw, IntPtr text, int length, int embedding_level, out int logical_widths);

		public int GetLogicalWidths(string text, int embedding_level) {
			int logical_widths;
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			pango_glyph_string_get_logical_widths(Handle, native_text, System.Text.Encoding.UTF8.GetByteCount (text), embedding_level, out logical_widths);
			GLib.Marshaller.Free (native_text);
			return logical_widths;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_glyph_string_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_glyph_string_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_glyph_string_get_width(IntPtr raw);

		public int Width { 
			get {
				int raw_ret = pango_glyph_string_get_width(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_index_to_x(IntPtr raw, IntPtr text, int length, IntPtr analysis, int index_, bool trailing, out int x_pos);

		public int IndexToX(string text, Pango.Analysis analysis, int index_, bool trailing) {
			int x_pos;
			IntPtr native_analysis = GLib.Marshaller.StructureToPtrAlloc (analysis);
			pango_glyph_string_index_to_x(Handle, GLib.Marshaller.StringToPtrGStrdup(text), System.Text.Encoding.UTF8.GetByteCount (text), native_analysis, index_, trailing, out x_pos);
			Marshal.FreeHGlobal (native_analysis);
			return x_pos;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_set_size(IntPtr raw, int new_len);

		public int Size { 
			set {
				pango_glyph_string_set_size(Handle, value);
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_x_to_index(IntPtr raw, IntPtr text, int length, IntPtr analysis, int x_pos, out int index_, out int trailing);

		public void XToIndex(string text, Pango.Analysis analysis, int x_pos, out int index_, out int trailing) {
			IntPtr native_analysis = GLib.Marshaller.StructureToPtrAlloc (analysis);
			pango_glyph_string_x_to_index(Handle, GLib.Marshaller.StringToPtrGStrdup(text), System.Text.Encoding.UTF8.GetByteCount (text), native_analysis, x_pos, out index_, out trailing);
			Marshal.FreeHGlobal (native_analysis);
		}

		public GlyphString(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_glyph_string_new();

		public GlyphString () 
		{
			Raw = pango_glyph_string_new();
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_glyph_string_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			pango_glyph_string_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return pango_glyph_string_free;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("num_glyphs"
							, 0
							, (uint) Marshal.SizeOf(typeof(int)) // num_glyphs
							, null
							, "glyphs"
							, (long) Marshal.OffsetOf(typeof(PangoGlyphString_num_glyphsAlign), "num_glyphs")
							, 0
							),
						new GLib.AbiField("glyphs"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // glyphs
							, "num_glyphs"
							, "log_clusters"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("log_clusters"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // log_clusters
							, "glyphs"
							, "space"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("space"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // space
							, "log_clusters"
							, null
							, (long) Marshal.OffsetOf(typeof(PangoGlyphString_spaceAlign), "space")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoGlyphString_num_glyphsAlign
		{
			sbyte f1;
			private int num_glyphs;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoGlyphString_spaceAlign
		{
			sbyte f1;
			private int space;
		}


		// End of the ABI representation.

#endregion
	}
}