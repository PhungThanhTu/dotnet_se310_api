﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.MarkdownDocuments;

namespace BLL.DTOs.Blocks
{
    public class GetBlocksResponse
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }    
        public string? MarkdownDocument { get; set; }
    }
}
