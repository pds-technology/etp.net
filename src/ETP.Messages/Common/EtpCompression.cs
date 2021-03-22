//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Energistics.Etp.Common
{
    /// <summary>
    /// ETP header names.
    /// </summary>
    public static class EtpCompression
    {
        /// <summary>
        /// GZip compression.
        /// </summary>
        public const string Gzip = "gzip";

        /// <summary>
        /// No compression.
        /// </summary>
        public const string None = "";

        /// <summary>
        /// The compressors for the compression methods.
        /// </summary>
        public static Dictionary<string, Func<Stream, Stream>> Compressors = new Dictionary<string, Func<Stream, Stream>>(StringComparer.OrdinalIgnoreCase)
        {
            [None] = (s) => null,
            [Gzip] = (s) => new GZipStream(s, CompressionMode.Compress, true),
        };

        /// <summary>
        /// The compressors for the compression methods.
        /// </summary>
        public static Dictionary<string, Func<Stream, Stream>> Decompressors = new Dictionary<string, Func<Stream, Stream>>(StringComparer.OrdinalIgnoreCase)
        {
            [None] = (s) => null,
            [Gzip] = (s) => new GZipStream(s, CompressionMode.Decompress, true),
        };

        /// <summary>
        /// Whether or not the specified compression method can be compressed and decompressed.
        /// </summary>
        /// <param name="compressionMethod">The compression method</param>
        /// <returns>>c>true</c> if the method can be used for both compression and decompression; <c>false</c> otherwise.</returns>
        public static bool IsSupportedCompressionMethod(string compressionMethod)
        {
            return CanCompress(compressionMethod) && CanDecompress(compressionMethod);
        }

        /// <summary>
        /// Whether or not the specified compression method requires compression.
        /// </summary>
        /// <param name="compressionMethod">The compression method</param>
        /// <returns></returns>
        public static bool RequiresCompression(string compressionMethod)
        {
            return !string.IsNullOrEmpty(compressionMethod);
        }

        /// <summary>
        /// Whether or not the specified compression method can be compressed.
        /// </summary>
        /// <param name="compressionMethod">The compression method</param>
        /// <returns>>c>true</c> if there is a compressor registered for the method; <c>false</c> otherwise.</returns>
        public static bool CanCompress(string compressionMethod)
        {
            if (string.IsNullOrEmpty(compressionMethod))
                return true;

            return Compressors.ContainsKey(compressionMethod);
        }

        /// <summary>
        /// Whether or not the specified compression method requires decompression.
        /// </summary>
        /// <param name="compressionMethod">The compression method</param>
        /// <returns></returns>
        public static bool RequiresDecompression(string compressionMethod)
        {
            return !string.IsNullOrEmpty(compressionMethod);
        }

        /// <summary>
        /// Whether or not the specified compression method can be decompressed.
        /// </summary>
        /// <param name="compressionMethod">The compression method</param>
        /// <returns>>c>true</c> if there is a decompressor registered for the method; <c>false</c> otherwise.</returns>
        public static bool CanDecompress(string compressionMethod)
        {
            if (string.IsNullOrEmpty(compressionMethod))
                return true;

            return Decompressors.ContainsKey(compressionMethod);
        }

        /// <summary>
        /// Tries to get the compression stream for the specified input stream.
        /// </summary>
        /// <param name="compressionMethod">The compression method to use.</param>
        /// <param name="stream">The stream to wrap with the compression stream.</param>
        /// <returns>The compression stream if successful; <c>null</c> otherwise.</returns>
        public static Stream TryGetCompresionStream(string compressionMethod, Stream stream)
        {
            if (string.IsNullOrEmpty(compressionMethod))
                return null;

            Func<Stream, Stream> compressor;
            if (Compressors.TryGetValue(compressionMethod, out compressor))
                return compressor(stream);

            return null;
        }

        /// <summary>
        /// Tries to get the decompression stream for the specified input stream.
        /// </summary>
        /// <param name="compressionMethod">The compression method to use.</param>
        /// <param name="stream">The stream to wrap with the decompression stream.</param>
        /// <returns>The decompression stream if successful; <c>null</c> otherwise.</returns>
        public static Stream TryGetDecompresionStream(string compressionMethod, Stream stream)
        {
            if (string.IsNullOrEmpty(compressionMethod))
                return null;

            Func<Stream, Stream> decompressor;
            if (Decompressors.TryGetValue(compressionMethod, out decompressor))
                return decompressor(stream);

            return null;
        }
    }
}
