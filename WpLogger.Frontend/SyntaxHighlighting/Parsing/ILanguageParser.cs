﻿// Based on Jeff Wilcox' Syntax highlighter: http://www.jeff.wilcox.name/2010/03/syntax-highlighting-text-block/
// He really deservces most of the credits...

// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
// <auto-generated />
// No style analysis for imported project.

using System;
using System.Collections.Generic;

namespace SharpGIS.SyntaxHighlighting
{
    internal interface ILanguageParser
    {
        void Parse(string sourceCode,
                   ILanguage language,
                   Action<string, IList<Scope>> parseHandler);
    }
}