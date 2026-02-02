using Application.Commands.CreateTodoItem;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Presentation.Infrastructure;

namespace Presentation.Infrastructure;

public class Users : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapGet(GetUser).RequireAuthorization();
        groupBuilder.MapPost(CreateUser).RequireAuthorization();
        groupBuilder.MapDelete(DeleteUser, "{id}").RequireAuthorization();
    }

    public async Task<UserBriefDto> GetUser(ISender sender, [AsParameters] GetUserQuery query)
    {
        var result = await sender.Send(query);

        return result;
    }

    public async Task<Created<int>> CreateUser(ISender sender, [AsParameters] CreateUserCommand command)
    {
        var id = await sender.Send(command);

        return TypedResults.Created($"/{nameof(Users)}/{id}", id);
    }
    public async Task<NoContent> DeleteUser(ISender sender, int id)
    {
        await sender.Send(new DeleteUserCommand(id));

        return TypedResults.NoContent();
    }
    /*
    public async Task<Results<NoContent, BadRequest>> UpdateUser(ISender sender, int id, UpdateUserCommand command)
    {
        if (id != command.Id) return TypedResults.BadRequest();

        await sender.Send(command);

        return TypedResults.NoContent();
    }
    */
}
