﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Global
{
    public interface IUpdateable
    {
        void Update(GameTime Time);
    }
}
