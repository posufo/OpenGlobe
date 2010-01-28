﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the Boost Software License, Version 1.0.
// See License.txt or http://www.boost.org/LICENSE_1_0.txt.
//
#endregion

using OpenTK;

namespace MiniGlobe.Core.Geometry
{
    public class IndicesByte : Indices<byte>
    {
        public IndicesByte()
            : base(IndicesType.Byte)
        {
        }

        public IndicesByte(int capacity)
            : base(IndicesType.Byte, capacity)
        {
        }
    }
}
