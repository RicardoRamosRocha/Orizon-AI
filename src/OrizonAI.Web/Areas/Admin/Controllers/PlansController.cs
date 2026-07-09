using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class PlansController : Controller
{
    private readonly IPlanService _planService;

    public PlansController(IPlanService planService)
    {
        _planService = planService;
    }

    public async Task<IActionResult> Index()
    {
        var plans = await _planService.GetAllAsync();
        return View(plans);
    }

    public async Task<IActionResult> Details(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _planService.GetByIdAsync(id.Value);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    public IActionResult Create()
    {
        return View(new Plan());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Name,Description,MonthlyPrice,CreditsIncluded,MaxUsers,MaxTokensPerMonth,Active")]
        Plan plan)
    {
        if (!ModelState.IsValid)
            return View(plan);

        plan.Id = Guid.NewGuid();
        plan.CreatedAt = DateTime.UtcNow;

        await _planService.CreateAsync(plan);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _planService.GetByIdAsync(id.Value);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        Guid id,
        [Bind("Id,Name,Description,MonthlyPrice,CreditsIncluded,MaxUsers,MaxTokensPerMonth,Active,CreatedAt")]
        Plan plan)
    {
        if (id != plan.Id)
            return NotFound();

        if (!ModelState.IsValid)
            return View(plan);

        var existingPlan = await _planService.GetByIdAsync(id);

        if (existingPlan is null)
            return NotFound();

        await _planService.UpdateAsync(plan);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _planService.GetByIdAsync(id.Value);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _planService.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}