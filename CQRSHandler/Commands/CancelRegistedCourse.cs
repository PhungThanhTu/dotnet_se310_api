﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSHandler.Abstractions;

namespace CQRSHandler.Commands
{
    public class CancelRegistedCourse : ICommand
    {
        public string? Json { get; set; }
    }
}
