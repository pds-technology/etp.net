//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2021 Energistics
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
using System.Globalization;
using System.IO;
using System.Text;

namespace Energistics.CodeGen.Code
{
    /// <summary>
    /// Class for writing code.
    /// </summary>
    public sealed class CodeWriter : TextWriter
    {
        public CodeWriter(TextWriter writer)
            : this(writer, "    ")
        {

        }

        public CodeWriter(TextWriter writer, string indentation)
        {
            Indentation = indentation;
            Writer = writer;
            Scopes.Push(new CodeScope());
        }

        private string Indentation { get; }

        private TextWriter Writer { get; }

        public override Encoding Encoding => Writer.Encoding;

        public override IFormatProvider FormatProvider => CultureInfo.InvariantCulture;

        private bool IsNewLine { get; set; } = true;

        private Stack<CodeScope> Scopes { get; } = new Stack<CodeScope>();

        private CodeScope Top => Scopes.Peek();

        private int IndentationLevel => Top.IndentationLevel;

        public override void Write(char c)
        {
            if (IsNewLine)
            {
                for (int i = 0; i < IndentationLevel; i++)
                    Writer.Write(Indentation);
                IsNewLine = false;
            }

            if (c == NewLine[NewLine.Length - 1])
                IsNewLine = true;

            Writer.Write(c);
        }

        public void PushScope()
        {
            Scopes.Push(new CodeScope
            {
                IndentationLevel = IndentationLevel + 1,
            });
        }

        public void PushIndentation()
        {
            Top.IndentationLevel++;
        }

        public void PopIndentation()
        {
            Top.IndentationLevel--;
        }

        public void PopScope() => Scopes.Pop();

        /// <summary>
        /// Gets a unique variable name within the scope starting with the prefix.
        /// </summary>
        /// <param name="variablePrefix">The variable name prefix.</param>
        /// <returns>The unique variable name.</returns>
        public string GetUniqueVariable(string variablePrefix) => Top.GetUniqueVariable(variablePrefix);
    }
}
