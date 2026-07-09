using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;
using OrizonAI.Web.Areas.Admin.ViewModels.AIProviders;

namespace OrizonAI.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class AIProvidersController : Controller
{
    private readonly IAIProviderService _service;

    public AIProvidersController(IAIProviderService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var providers = await _service.GetAllAsync();
        return View(providers);
    }

    public async Task<IActionResult> Details(Guid? id)
    {
        if (id is null)
            return NotFound();

        var provider = await _service.GetByIdAsync(id.Value);

        if (provider is null)
            return NotFound();

        return View(provider);
    }

    public IActionResult Create()
    {
        return View(new AIProviderFormViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AIProviderFormViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var provider = new AIProvider
        {
            Type = model.Type,
            Name = model.Name,
            DisplayName = model.DisplayName,
            BaseUrl = model.BaseUrl,
            ApiKey = model.ApiKey,
            OrganizationId = model.OrganizationId,
            ApiVersion = model.ApiVersion,
            Priority = model.Priority,
            TimeoutSeconds = model.TimeoutSeconds,
            RetryCount = model.RetryCount,
            SupportsStreaming = model.SupportsStreaming,
            SupportsVision = model.SupportsVision,
            SupportsAudio = model.SupportsAudio,
            Active = model.Active
        };

        await _service.CreateAsync(provider);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id is null)
            return NotFound();

        var provider = await _service.GetByIdAsync(id.Value);

        if (provider is null)
            return NotFound();

        var model = new AIProviderFormViewModel
        {
            Id = provider.Id,
            Type = provider.Type,
            Name = provider.Name,
            DisplayName = provider.DisplayName,
            BaseUrl = provider.BaseUrl,
            ApiKey = provider.ApiKey,
            OrganizationId = provider.OrganizationId,
            ApiVersion = provider.ApiVersion,
            Priority = provider.Priority,
            TimeoutSeconds = provider.TimeoutSeconds,
            RetryCount = provider.RetryCount,
            SupportsStreaming = provider.SupportsStreaming,
            SupportsVision = provider.SupportsVision,
            SupportsAudio = provider.SupportsAudio,
            Active = provider.Active
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, AIProviderFormViewModel model)
    {
        if (id != model.Id)
            return NotFound();

        if (!ModelState.IsValid)
            return View(model);

        var provider = await _service.GetByIdAsync(id);

        if (provider is null)
            return NotFound();

        provider.Type = model.Type;
        provider.Name = model.Name;
        provider.DisplayName = model.DisplayName;
        provider.BaseUrl = model.BaseUrl;
        provider.ApiKey = model.ApiKey;
        provider.OrganizationId = model.OrganizationId;
        provider.ApiVersion = model.ApiVersion;
        provider.Priority = model.Priority;
        provider.TimeoutSeconds = model.TimeoutSeconds;
        provider.RetryCount = model.RetryCount;
        provider.SupportsStreaming = model.SupportsStreaming;
        provider.SupportsVision = model.SupportsVision;
        provider.SupportsAudio = model.SupportsAudio;
        provider.Active = model.Active;

        await _service.UpdateAsync(provider);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id is null)
            return NotFound();

        var provider = await _service.GetByIdAsync(id.Value);

        if (provider is null)
            return NotFound();

        return View(provider);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _service.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}