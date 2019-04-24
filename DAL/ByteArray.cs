using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ByteArray
    {
        List<byte> list;
        public ByteArray()
        {
            list = new List<byte>();
        }
        public ByteArray(int size)
        {
            list = new List<byte>(size);
        }
        public byte[] array
        {
            get { return list.ToArray(); }
        }
        public void Add(byte item)
        {
            list.Add(item);
        }
        public void Add(byte[] items)
        {
            list.AddRange(items);
        }
        public void Clear()
        {
            list.Clear();
        }

    }
}
