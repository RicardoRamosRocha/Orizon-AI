using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;
using OrizonAI.Web.Areas.Admin.ViewModels.AIModels;

namespace OrizonAI.Web.Areas.Admin.Controllers;

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

        var viewModel = new AIModelFormViewModel
        {
            Active = true
        };

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AIModelFormViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            await LoadProvidersAsync(viewModel.AIProviderId);
            return View(viewModel);
        }

        var model = new AIModel
        {
            Id = Guid.NewGuid(),
            AIProviderId = viewModel.AIProviderId,
            Name = viewModel.Name,
            Identifier = viewModel.Identifier,
            Modalities = viewModel.Modalities,
            ContextWindow = viewModel.ContextWindow,
            MaxOutputTokens = viewModel.MaxOutputTokens,
            InputTokenPricePerMillion = viewModel.InputTokenPricePerMillion,
            OutputTokenPricePerMillion = viewModel.OutputTokenPricePerMillion,
            Active = viewModel.Active,
            CreatedAt = DateTime.UtcNow
        };

        await _modelService.AddAsync(model);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        var model = await _modelService.GetByIdAsync(id);

        if (model == null)
            return NotFound();

        var viewModel = new AIModelFormViewModel
        {
            Id = model.Id,
            AIProviderId = model.AIProviderId,
            Name = model.Name,
            Identifier = model.Identifier,
            Modalities = model.Modalities,
            ContextWindow = model.ContextWindow,
            MaxOutputTokens = model.MaxOutputTokens,
            InputTokenPricePerMillion = model.InputTokenPricePerMillion,
            OutputTokenPricePerMillion = model.OutputTokenPricePerMillion,
            Active = model.Active
        };

        await LoadProvidersAsync(model.AIProviderId);

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, AIModelFormViewModel viewModel)
    {
        if (id != viewModel.Id)
            return NotFound();

        if (!ModelState.IsValid)
        {
            await LoadProvidersAsync(viewModel.AIProviderId);
            return View(viewModel);
        }

        var model = await _modelService.GetByIdAsync(id);

        if (model == null)
            return NotFound();

        model.AIProviderId = viewModel.AIProviderId;
        model.Name = viewModel.Name;
        model.Identifier = viewModel.Identifier;
        model.Modalities = viewModel.Modalities;
        model.ContextWindow = viewModel.ContextWindow;
        model.MaxOutputTokens = viewModel.MaxOutputTokens;
        model.InputTokenPricePerMillion = viewModel.InputTokenPricePerMillion;
        model.OutputTokenPricePerMillion = viewModel.OutputTokenPricePerMillion;
        model.Active = viewModel.Active;
        model.UpdatedAt = DateTime.UtcNow;

        await _modelService.UpdateAsync(model);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(Guid id)
    {
        var model = await _modelService.GetByIdAsync(id);

        if (model == null)
            return NotFound();

        return View(model);
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