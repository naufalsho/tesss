﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{ 
    public class ResultAction
    {
        public string ErrorNumber { get; set; }

        public bool bSuccess { get; set; }

        public string Message { get; set; }
        public object ResultObj { get; set; }
    }
}
