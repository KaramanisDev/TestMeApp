using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Text;

namespace CoolPrintPreview
{
#if false

    // PageImageList stores images as byte arrays.

    class PageImageList
    {
        // ** fields
        List<byte[]> _list = new List<byte[]>();

        // ** object model
        public void Clear()
        {
            _list.Clear();
        }
        public int Count
        {
            get { return _list.Count; }
        }
        public void Add(Image img)
        {
            _list.Add(GetBytes(img));

            // stored image data, now dispose of original
            img.Dispose();
        }
        public Image this[int index]
        {
            get { return GetImage(_list[index]); }
            set { _list[index] = GetBytes(value); }
        }

        // implementation
        byte[] GetBytes(Image img)
        {
            // use interop to get the metafile bits
            Metafile mf = img as Metafile;
            var enhMetafileHandle = mf.GetHenhmetafile().ToInt32();
            var bufferSize = GetEnhMetaFileBits(enhMetafileHandle, 0, null);
            var buffer = new byte[bufferSize];
            GetEnhMetaFileBits(enhMetafileHandle, bufferSize, buffer);

            // return bits
            return buffer;
        }
        Image GetImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        [System.Runtime.InteropServices.DllImport("gdi32")]
        static extern int GetEnhMetaFileBits(int hemf, int cbBuffer, byte[] lpbBuffer);
    }

#else

    // This version of the PageImageList is a simple List<Image>. It is simple,
    // but caches one image (GDI object) per preview page.
    class PageImageList : List<Image>
    {
    }

#endif
}
