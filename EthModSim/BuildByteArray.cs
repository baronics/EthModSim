using System.IO;

namespace EthModSim
{
    /// <summary>
    /// Build a byte array with specific MCP byte ordering
    /// </summary>
    public class BuildByteArray : BinaryWriter
    {
        public BuildByteArray() : base(new MemoryStream())
        {
        }

        /// <summary>
        /// Add 1 byte
        /// </summary>
        /// <param name="b"></param>
        public void Add(byte b)
        {
            Write(b);
        }

        public void Add(int i)
        {
            Add((byte)i);
        }

        /// <summary>
        /// Add a string as an array of bytes
        /// NOTE: BinaryWriter Write(string) prepends an extra byte
        /// </summary>
        /// <param name="value"></param>
        public void Add(string value)
        {
            Write(value.ToCharArray());
        }

        public void AddWithLength(string value)
        {
            Add(value.Length);
            Add(value);
        }

        /// <summary>
        /// Get the underlying stream as an array of bytes
        /// </summary>
        /// <returns></returns>
        public byte[] ToArray()
        {
            return ((MemoryStream)BaseStream).ToArray();
        }
    }
}
