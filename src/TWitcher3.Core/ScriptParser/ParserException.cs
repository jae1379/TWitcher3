﻿using System;

namespace TWitcher3.Core.ScriptParser
{
    public class ParserException : Exception
    {
        public ParserException(string message)
            : base(message)
        {
        }
    }
}