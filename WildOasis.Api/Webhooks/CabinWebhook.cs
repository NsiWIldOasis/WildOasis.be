using Demo.Auth.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WildOasis.Application.Cabin.Commands;

namespace WilaOasis.Api.Webhooks;

[Authorize(AuthenticationSchemes = nameof(AuthConstants.HeaderBasicAuthenticationScheme))]

public class CabinWebhook: BaseWebhook
{
    [HttpPost]
    public async Task<IActionResult> Create(CabinCommandCreate command) => Ok(await Mediator.Send(command));

}