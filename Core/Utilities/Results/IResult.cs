﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel void için başlangıç
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
