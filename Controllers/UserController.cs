using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using TWValidacao.Models;
using TWValidacao.Validators;

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
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Houveram erros de validação");
            ViewData["Title"] = "Cadastro de Usuário";
            return View();
        }
        Console.WriteLine("Não houveram erros de validação");
        return RedirectToAction();
    }

}