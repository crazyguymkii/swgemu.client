﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWG.Client.Network
{
    public interface IHasFallbackMessageFactory
    {
        IMessageParseFactory FallbackFactory { get; set; }
    }
}
