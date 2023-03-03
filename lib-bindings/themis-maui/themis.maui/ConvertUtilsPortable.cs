﻿using System;
using System.IO;
using System.Text;

namespace Themis
{
    public static class ConvertUtilsPortable
    {
        public static byte[] StreamToByteArray(Stream stream)
        {
            if (stream == null)
            {
                return null;
            }

            using (var memStream = new MemoryStream())
            {
                stream.CopyTo(memStream);
                byte[] result = memStream.GetBuffer();

                return result;
            }
        }

        public static MemoryStream ByteArrayToMemoryStream(byte[] data)
        {
            if (data == null)
            {
                return null;
            }

            var result =
                new MemoryStream(
                    buffer: data,
                    index: 0,
                    count: data.Length,
                    writable: false,
                    publiclyVisible: true);

            return result;
        }

        public static MemoryStream StringToMemoryStream(string str)
        {
            byte[] data = StringToByteArray(str);
            MemoryStream result = ByteArrayToMemoryStream(data);

            return result;
        }

        public static byte[] StringToByteArray(string str)
        {
            if (str == null)
            {
                return null;
            }

            byte[] result = Encoding.UTF8.GetBytes(str);

            return result;
        }

        public static string ByteArrayToString(byte[] stringAsTextData)
        {
            if (stringAsTextData == null)
            {
                return null;
            }

            string result = Encoding.UTF8.GetString(stringAsTextData);

            return result;
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            if (data == null)
            {
                return null;
            }

            string result = BitConverter.ToString(data).Replace("-", string.Empty);
            return result;
        }
    }
}
