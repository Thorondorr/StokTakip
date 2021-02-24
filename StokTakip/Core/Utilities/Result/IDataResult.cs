﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
