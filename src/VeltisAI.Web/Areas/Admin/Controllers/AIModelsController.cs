using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VeltisAI.Application.Interfaces.Services;
using VeltisAI.Domain.Entities;

namespace VeltisAI.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class AIModelsController : Controller
{
    private readonly IAIModelService _modelService;
    private readonly IAIProviderService _providerService;

    public AIModelsController(
        IAIModelService modelService,
        IAIProviderService providerService)
    {
        _modelService = modelService;
        _providerService = providerService;
    }

    public async Task<IActionResult> Index()
    {
        var models = await _modelService.GetAllAsync();
        return View(models);
    }

    public async Task<IActionResult> Create()
    {
        await LoadProvidersAsync();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AIModel model)
    {
        if (!ModelState.IsValid)
        {
            await LoadProvidersAsync();
            return View(model);
        }

        model.Id = Guid.NewGuid();
        model.CreatedAt = DateTime.UtcNow;

        await _modelService.AddAsync(model);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        var model = await _modelService.GetByIdAsync(id);

        if (model == null)
            return NotFound();

        await LoadProvidersAsync(model.AIProviderId);

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, AIModel model)
    {
        if (id != model.Id)
            return NotFound();

        if (!ModelState.IsValid)
        {
            await LoadProvidersAsync(model.AIProviderId);
            return View(model);
        }

        model.UpdatedAt = DateTime.UtcNow;

        await _modelService.UpdateAsync(model);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _modelService.GetByIdAsync(id);

        if (model == null)
            return NotFound();

        return View(model);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _modelService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task LoadProvidersAsync(Guid? selectedProviderId = null)
    {
        var providers = await _providerService.GetAllAsync();

        ViewBag.AIProviderId = new SelectList(
            providers,
            "Id",
            "DisplayName",
            selectedProviderId);
    }
}