﻿using Application;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API;

public class ActivitiesController : BaseApiController
{

    [HttpGet]
    public async Task<IActionResult> GetActivities()
    {
        return HandleResult(await Mediator.Send(new List.Query()));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivities(Guid id)
    {
        var result = await Mediator.Send(new Details.Query { Id = id });
        return HandleResult(result);

    }

    [HttpPost]
    public async Task<IActionResult> CreateActivity(Activity activity)
    {
        return HandleResult(await Mediator.Send(new Create.Command { Activity = activity }));

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditActivity(Guid id, Activity activity)
    {
        activity.Id = id;
        return HandleResult(await Mediator.Send(new Edit.Command { Activity = activity }));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
    }
}
