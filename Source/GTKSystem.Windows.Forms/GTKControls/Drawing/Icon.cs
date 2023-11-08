using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;

namespace System.Drawing
{
	/// <summary>Represents a Windows icon, which is a small bitmap image that is used to represent an object. Icons can be thought of as transparent bitmaps, although their size is determined by the system.</summary>
	[TypeConverter("System.Drawing.IconConverter, System.Windows.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51")]
	public sealed class Icon : MarshalByRefObject, ICloneable, IDisposable, ISerializable
	{
		/// <summary>Gets the Windows handle for this <see cref="T:System.Drawing.Icon" />. This is not a copy of the handle; do not free it.</summary>
		/// <returns>The Windows handle for the icon.</returns>
		[Browsable(false)]
		public IntPtr Handle
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Gets the height of this <see cref="T:System.Drawing.Icon" />.</summary>
		/// <returns>The height of this <see cref="T:System.Drawing.Icon" />.</returns>
		[Browsable(false)]
		public int Height
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Gets the size of this <see cref="T:System.Drawing.Icon" />.</summary>
		/// <returns>A <see cref="T:System.Drawing.Size" /> structure that specifies the width and height of this <see cref="T:System.Drawing.Icon" />.</returns>
		public Size Size
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Gets the width of this <see cref="T:System.Drawing.Icon" />.</summary>
		/// <returns>The width of this <see cref="T:System.Drawing.Icon" />.</returns>
		[Browsable(false)]
		public int Width
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class and attempts to find a version of the icon that matches the requested size.</summary>
		/// <param name="original">The <see cref="T:System.Drawing.Icon" /> from which to load the newly sized icon.</param>
		/// <param name="size">A <see cref="T:System.Drawing.Size" /> structure that specifies the height and width of the new <see cref="T:System.Drawing.Icon" />.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="original" /> parameter is <see langword="null" />.</exception>
		public Icon(Icon original, Size size)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class and attempts to find a version of the icon that matches the requested size.</summary>
		/// <param name="original">The icon to load the different size from.</param>
		/// <param name="width">The width of the new icon.</param>
		/// <param name="height">The height of the new icon.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="original" /> parameter is <see langword="null" />.</exception>
		public Icon(Icon original, int width, int height)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from the specified data stream.</summary>
		/// <param name="stream">The data stream from which to load the <see cref="T:System.Drawing.Icon" />.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is <see langword="null" />.</exception>
		public Icon(Stream stream)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class of the specified size from the specified stream.</summary>
		/// <param name="stream">The stream that contains the icon data.</param>
		/// <param name="size">The desired size of the icon.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="stream" /> is <see langword="null" /> or does not contain image data.</exception>
		public Icon(Stream stream, Size size)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from the specified data stream and with the specified width and height.</summary>
		/// <param name="stream">The data stream from which to load the icon.</param>
		/// <param name="width">The width, in pixels, of the icon.</param>
		/// <param name="height">The height, in pixels, of the icon.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is <see langword="null" />.</exception>
		public Icon(Stream stream, int width, int height)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from the specified file name.</summary>
		/// <param name="fileName">The file to load the <see cref="T:System.Drawing.Icon" /> from.</param>
		public Icon(string fileName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class of the specified size from the specified file.</summary>
		/// <param name="fileName">The name and path to the file that contains the icon data.</param>
		/// <param name="size">The desired size of the icon.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="string" /> is <see langword="null" /> or does not contain image data.</exception>
		public Icon(string fileName, Size size)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class with the specified width and height from the specified file.</summary>
		/// <param name="fileName">The name and path to the file that contains the <see cref="T:System.Drawing.Icon" /> data.</param>
		/// <param name="width">The desired width of the <see cref="T:System.Drawing.Icon" />.</param>
		/// <param name="height">The desired height of the <see cref="T:System.Drawing.Icon" />.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="string" /> is <see langword="null" /> or does not contain image data.</exception>
		public Icon(string fileName, int width, int height)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from a resource in the specified assembly.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that specifies the assembly in which to look for the resource.</param>
		/// <param name="resource">The resource name to load.</param>
		/// <exception cref="T:System.ArgumentException">An icon specified by <paramref name="resource" /> cannot be found in the assembly that contains the specified <paramref name="type" />.</exception>
		public Icon(Type type, string resource)
		{
		}

		/// <summary>Clones the <see cref="T:System.Drawing.Icon" />, creating a duplicate image.</summary>
		/// <returns>An object that can be cast to an <see cref="T:System.Drawing.Icon" />.</returns>
		public object Clone()
		{
			throw null;
		}

		/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Icon" />.</summary>
		public void Dispose()
		{
		}

		/// <summary>Returns an icon representation of an image that is contained in the specified file.</summary>
		/// <param name="filePath">The path to the file that contains an image.</param>
		/// <returns>The <see cref="T:System.Drawing.Icon" /> representation of the image that is contained in the specified file.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="filePath" /> does not indicate a valid file.
		/// -or-
		/// The <paramref name="filePath" /> indicates a Universal Naming Convention (UNC) path.</exception>
		public static Icon ExtractAssociatedIcon(string filePath)
		{
			throw null;
		}

		/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
		~Icon()
		{
		}

		/// <summary>Creates a GDI+ <see cref="T:System.Drawing.Icon" /> from the specified Windows handle to an icon (<see langword="HICON" />).</summary>
		/// <param name="handle">A Windows handle to an icon.</param>
		/// <returns>The <see cref="T:System.Drawing.Icon" /> this method creates.</returns>
		public static Icon FromHandle(IntPtr handle)
		{
			throw null;
		}

		/// <summary>Saves this <see cref="T:System.Drawing.Icon" /> to the specified output <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="outputStream">The <see cref="T:System.IO.Stream" /> to save to.</param>
		public void Save(Stream outputStream)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is required to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Converts this <see cref="T:System.Drawing.Icon" /> to a GDI+ <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <returns>A <see cref="T:System.Drawing.Bitmap" /> that represents the converted <see cref="T:System.Drawing.Icon" />.</returns>
		public Bitmap ToBitmap()
		{
			throw null;
		}

		/// <summary>Gets a human-readable string that describes the <see cref="T:System.Drawing.Icon" />.</summary>
		/// <returns>A string that describes the <see cref="T:System.Drawing.Icon" />.</returns>
		public override string ToString()
		{
			throw null;
		}
	}
}