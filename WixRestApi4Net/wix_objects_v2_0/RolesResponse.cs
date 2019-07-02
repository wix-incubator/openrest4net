﻿using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class RolesResponse
    {
        public string userId;
        public IList<Role> roles = new List<Role>();

        /** Empty constructor required for initialization from JSON-encoded string. */
        public RolesResponse()
        {
        }

        public RolesResponse(string userId, IList<Role> roles)
        {
            this.userId = userId;
            this.roles = roles;
        }
    }
}