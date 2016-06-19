﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UniqUDAL.DataTransferObjects
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool _boolValue = true;
        private string _stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return _boolValue; }
            set { _boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}