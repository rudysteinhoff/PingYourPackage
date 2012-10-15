﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Services {
    
    public class CreatedUserResult : CreatedResult {

        public CreatedUserResult(bool isSuccess) 
            : base(isSuccess) { 
        }

        public UserWithRoles User { get; set; }
    }
}