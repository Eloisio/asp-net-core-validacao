using Microsoft.AspNetCore.Mvc;
using TWValidacao.Models;

namespace TWValidacao.Controllers;

public class UserController : Controller
{

    public IActionResult Create()
    {
        ViewData["Title"] = "Cadastro de Usuário";
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateUserViewModel formData)
    {
        Console.WriteLine(formData.FirstName);
        Console.WriteLine(formData.LastName);
        Console.WriteLine(formData.Email);
        return RedirectToAction();
    }

}