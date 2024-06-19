using FitShirt.Domain.Security.Models.Commands;
using FitShirt.Domain.Security.Models.Responses;

namespace FitShirt.Domain.Security.Services;

public interface IUserCommandService
{
    Task<UserResponse> Handle(int id, LoginUserCommand command);
    Task<UserResponse> Handle(RegisterUserCommand command);
}