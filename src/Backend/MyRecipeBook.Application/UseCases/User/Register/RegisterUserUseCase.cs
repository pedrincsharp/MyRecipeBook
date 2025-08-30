using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBook.Application.UseCases.User.Register;
public class RegisterUserUseCase
{
    public RegisterUserResposne Execute(RegisterUserRequest request)
    {
        // Validar a request
        this.Validate(request);

        // Mapear a request em uma entidade (dto -> entity)

        // Criptografia da senha

        // Salvar no banco de dados

        return new RegisterUserResposne()
        {
            name = request.name
        };
    }

    private void Validate(RegisterUserRequest request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(x => x.ErrorMessage)
                .ToList();

            throw new Exception(string.Join(", ", errors));
        }
    }
}