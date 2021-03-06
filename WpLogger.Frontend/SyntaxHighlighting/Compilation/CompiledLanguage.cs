﻿// Based on Jeff Wilcox' Syntax highlighter: http://www.jeff.wilcox.name/2010/03/syntax-highlighting-text-block/
// He really deservces most of the credits...

// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
// <auto-generated />
// No style analysis for imported project.

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SharpGIS.SyntaxHighlighting
{
    internal class CompiledLanguage
    {
        public CompiledLanguage(string id,
                                string name,
                                Regex regex,
                                IList<string> captures)
        {
            Guard.ArgNotNullAndNotEmpty(id, "id");
            Guard.ArgNotNullAndNotEmpty(name, "name");
            Guard.ArgNotNull(regex, "regex");
            Guard.ArgNotNullAndNotEmpty(captures, "captures");
            
            Id = id;
            Name = name;
            Regex = regex;
            Captures = captures;
        }

        public IList<string> Captures { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public Regex Regex { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}