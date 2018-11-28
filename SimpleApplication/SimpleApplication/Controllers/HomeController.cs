﻿using SimpleApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleApplication.Controllers
{
public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            {
                if (ModelState.IsValid)
                    // Нужно отправить данные нового гостя по электронной почте 
                    // организатору вечеринки.
                    return View("Thanks", guest);
                else
                    // Обнаружена ошибка проверки достоверности
                    return View();
            }
        }
    }
}