using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[ProducesResponseType(typeof(RegisterUserResposne), StatusCodes.Status201Created)]
public class UserController : ControllerBase
{

    [HttpPost]
    public IActionResult Register(RegisterUserRequest request)
    {
        var useCase = new RegisterUserUseCase();

        var result = useCase.Execute(request);

        return Created("", result);
    }

}
