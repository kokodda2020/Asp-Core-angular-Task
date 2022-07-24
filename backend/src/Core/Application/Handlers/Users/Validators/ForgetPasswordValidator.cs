﻿using Application.Handlers.Users.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.Users.Validators
{
    public class ForgetPasswordValidator:AbstractValidator<ForgetPasswordCommand>
    {
        public ForgetPasswordValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}
