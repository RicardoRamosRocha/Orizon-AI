using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VeltisAI.Infrastructure.Identity;
using VeltisAI.Web.Models.Account;

namespace VeltisAI.Web.Controllers;

public class AccountController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var result = await _signInManager.PasswordSignInAsync(
            model.Email,
            model.Password,
            model.RememberMe,
            false);

        if (result.Succeeded)
            return RedirectToAction("Index", "Home", new { area = "Admin" });

        ModelState.AddModelError("", "E-mail ou senha inválidos.");
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }
}