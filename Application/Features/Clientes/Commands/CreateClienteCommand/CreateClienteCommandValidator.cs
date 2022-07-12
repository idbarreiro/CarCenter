using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Documento)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(15).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.TipoDocumento)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(5).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.PrimerNombre)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(20).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.SegundoNombre)
            .MaximumLength(20).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.PrimerApellido)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(20).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.SegundoApellido)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(20).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.Celular)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(15).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.Direccion)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .MaximumLength(80).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");

            RuleFor(p => p.Email)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            .EmailAddress().WithMessage("{PropertyName} debe ser una direccion de correo electronica valida")
            .MaximumLength(80).WithMessage("{PropertyName} no puede exceder los {MaxLength} caracteres");
        }
    }
}
