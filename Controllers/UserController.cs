using Microsoft.AspNetCore.Mvc;

namespace TWValidacao.Controllers;

public class UserController : Controller
{

    public IActionResult Create()
    {
        ViewData["Title"] = "Cadastro de Usuário";
        return View();
    }

}