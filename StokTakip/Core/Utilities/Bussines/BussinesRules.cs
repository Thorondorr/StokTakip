﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Bussines
{
    public class BussinesRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach(var logic in logics)
            {
                if (!logic.Succes)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
