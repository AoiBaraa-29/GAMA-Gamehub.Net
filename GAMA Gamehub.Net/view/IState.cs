﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public interface IState
    {
        void Next();
        void Prev();
    }
}