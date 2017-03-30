﻿using LAFBulkDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CredentialValues:IInputData
    {
        public string Value { get; set; }
        public string Description { get; set; }
        public int CredentialValueID { get; set; }
        public string Status { get; set; }

        public string UserGroupName { get; set; }
        public int UserGroupID { get; set; }

        public int credentialValueID { get; set; }

    }
}
