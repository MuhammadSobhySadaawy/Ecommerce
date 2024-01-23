﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Api.Model.user
{
    public class EditUserRoleModel
    {
        [Required]
        public string? UserId { get; set; }

        [Required]
        public string? RoleId { get; set; }
    }
}
