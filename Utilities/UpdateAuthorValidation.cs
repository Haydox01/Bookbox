﻿using Bookbox.DTOs;
using Bookbox.DTOs.Request;
using FluentValidation;

namespace Bookbox.Utilities
{
    public class UpdateAuthorValidation : AbstractValidator<UpdateAuthorDto>
    {
        public UpdateAuthorValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name has to be a minimum of 3 characters")
                .MaximumLength(30);


        }
    }
}
