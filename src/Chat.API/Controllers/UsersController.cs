﻿using System.Net.Mime;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChatLPCommon.Dtos;
using ChatLPCommon.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Chat.API.Controllers;

/// <summary>
/// Provides the REST Endpoints for the User Endpoints such as Login, Registering and user editing
/// </summary>
[ApiController]
[ApiVersion("1")]
[Route("/api/v{version:apiVersion}/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class UsersController : ControllerBase
{
    // TODO: Add Correct Request and Response DTOs

    /// <summary>Creates a new User</summary>
    /// <response code='200'>Successfully generated User</response>
    /// <response code='400'>Invalid Email or password too Short Password</response>
    /// <response code='409'>User with Email or Username already exists</response>
    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [Consumes(typeof(UserRegistrationDto), MediaTypeNames.Application.Json)]
    [Produces(typeof(ApiResponse<string?>))]
    public string Register([FromBody] UserRegistrationDto userRegistrationDto)
    {
        return "Not Implemented";
    }

    /// <summary> Authenticates the User with a JWT Token </summary>
    /// <response code='200'>Successfully generated JWT Token String</response>
    /// <response code='401'>Wrong Email, Username or Password</response>
    /// <response code='400'>Invalid Email or too Short Password</response>
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Consumes(typeof(UserLoginDto), MediaTypeNames.Application.Json)]
    [Produces(typeof(ApiResponse<string>))]
    public string Login([FromBody] UserLoginDto userLoginDto)
    {
        return "Not Implemented";
    }

    /// <summary>Updates a User</summary>
    /// <response code='200'>Successfully Updated User</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to update a user he's not permitted to</response>
    [HttpPut("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Consumes(typeof(UserUpdateDto), MediaTypeNames.Application.Json)]
    [Produces(typeof(ApiResponse<UserResponseDto>))]
    [Authorize]
    public string Update([FromBody] UserUpdateDto userUpdateDto)
    {
        return "Not Implemented";
    }

    /// <summary>Deletes a User</summary>
    /// <response code='200'>Successfully Deleted User</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to delete a user he's not permitted to</response>
    [HttpDelete("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Produces(typeof(ApiResponse<string>))]
    [Authorize]
    public string Delete()
    {
        return "Not Implemented";
    }

    /// <summary>Gets a User</summary>
    /// <response code='200'>Successfully Get User</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to get a user he's not permitted to</response>
    [HttpGet("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Produces(ApiResponse<UserResponseDto[]>)]
    [Authorize]
    public string Get()
    {
        return "String";
    }

    /// <summary>Writes a Message to a User</summary>
    /// <response code='200'>Successfully sent message</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to write a user he's not permitted to</response>
    [HttpPost("{userId}/messages")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ApiExplorerSettings(GroupName = "User Messages")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Consumes(typeof(ApiResponse<Message>))]
    [Produces(MediaTypeNames.Application.Json)]
    [Authorize]
    public string WriteMessage()
    {
        return "String";
    }

    /// <summary>Updates a Message</summary>
    /// <response code='200'>Successfully updated message</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to update a message he's not permitted to</response>
    [HttpPatch("{userId}/messages/{messageId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ApiExplorerSettings(GroupName = "User Messages")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Produces(MediaTypeNames.Application.Json)]
    [Authorize]
    public string UpdateMessage()
    {
        return "String";
    }

    /// <summary>Deletes A Message</summary>
    /// <response code='200'>Successfully deleted message</response>
    /// <response code='401'>If the user isn't logged in</response>
    /// <response code='403'>If the user tries to delete a message he's not permitted to</response>
    [HttpDelete("{userId}/messages/{messageId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ApiExplorerSettings(GroupName = "User Messages")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Produces(MediaTypeNames.Application.Json)]
    [Authorize]
    public string DeleteMessage()
    {
        return "String";
    }
}