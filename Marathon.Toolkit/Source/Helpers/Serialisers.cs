﻿// Marathon is licensed under the MIT License:
/* 
 * MIT License
 * 
 * Copyright (c) 2020 HyperPolygon64
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Marathon.Helpers
{
    public static class Strings
    {
        public static string[] ParseLineBreaks(string text)
            => text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        public static string ByteLengthToDecimalString(long i)
        {
            // Get absolute value.
            long absolute_i = i < 0 ? -i : i;

            // Determine the suffix and readable value.
            string suffix;
            double readable;

            // Exabyte
            if (absolute_i >= 0x1000000000000000)
            {
                suffix = "EB";
                readable = i >> 50;
            }

            // Petabyte
            else if (absolute_i >= 0x4000000000000)
            {
                suffix = "PB";
                readable = i >> 40;
            }

            // Terabyte
            else if (absolute_i >= 0x10000000000)
            {
                suffix = "TB";
                readable = i >> 30;
            }

            // Gigabyte
            else if (absolute_i >= 0x40000000)
            {
                suffix = "GB";
                readable = i >> 20;
            }

            // Megabyte
            else if (absolute_i >= 0x100000)
            {
                suffix = "MB";
                readable = i >> 10;
            }

            // Kilobyte
            else if (absolute_i >= 0x400)
            {
                suffix = "KB";
                readable = i;
            }

            // Byte
            else
            {
                suffix = "KB";
                readable = i % 1024 >= 1 ? i + 1024 - i % 1024 : i - i % 1024;
            }

            // Divide by 1024 to get fractional value.
            readable /= 1024;

            // Return formatted number with suffix.
            return readable.ToString("0 ") + suffix;
        }
    }

    internal class XML
    {
        /// <summary>
        /// Parses Contributors.xml to a TreeNode array.
        /// </summary>
        public static TreeNode[] ParseContributors()
        {
            List<TreeNode> contributors = new List<TreeNode>();

            XDocument xml = XDocument.Parse(Properties.Resources.Contributors);

            foreach (XElement contributorElem in xml.Root.Elements("Contributor"))
            {
                TreeNode node = new TreeNode {
                    Text = contributorElem.Value,
                    Tag = contributorElem.Attribute("URL").Value
                };

                contributors.Add(node);
            }

            return contributors.ToArray();
        }

        /// <summary>
        /// Parses SupportedFileTypes.xml to a string.
        /// </summary>
        public static string ParseSupportedFileTypes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            XDocument xml = XDocument.Parse(Properties.Resources.SupportedFileTypes);

            foreach (XElement supportedFileTypesElem in xml.Root.Elements("Type"))
            {
                string @extension = supportedFileTypesElem.Attribute("Extension").Value;

                stringBuilder.Append($"{supportedFileTypesElem.Value} ({@extension})|{@extension}|");
            }

            return stringBuilder.ToString().EndsWith("|") ?
                   stringBuilder.ToString().Remove(stringBuilder.Length - 1) :
                   stringBuilder.ToString();
        }
    }
}
