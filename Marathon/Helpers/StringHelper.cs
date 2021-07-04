﻿using System.IO;
using System.Text.RegularExpressions;

namespace Marathon.Helpers
{
    public class StringHelper
    {
        /// <summary>
        /// Returns the full extension from the file name (with a dot prefix).
        /// </summary>
        public static string GetFullExtension(string fileName)
            => Regex.Match(fileName, @"\..*").Value;

        /// <summary>
        /// Returns the file name completely extension-less.
        /// </summary>
        public static string RemoveFullExtension(string fileName)
            => Regex.Replace(fileName, @"\..*", string.Empty);

        /// <summary>
        /// Appends text to the file name before the extension.
        /// </summary>
        /// <param name="filePath">Full file path.</param>
        /// <param name="text">Text to append.</param>
        public static string AppendToFileName(string filePath, string text)
            => Path.GetFileNameWithoutExtension(filePath) + text + GetFullExtension(filePath);

        /// <summary>
        /// Returns a new path with the specified filename.
        /// </summary>
        public static string ReplaceFilename(string path, string newFile)
            => Path.Combine(Path.GetDirectoryName(path), Path.GetFileName(newFile));
    }
}