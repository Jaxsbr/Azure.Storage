﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.Domain.Entities
{
    public class BlobContainer
    {
        public string Name { get; set; }
        public DateTime LastModified { get; set; }
    }
}
