﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookService _bookService;

        public CategoryController(BookService bookService)
        {
            _bookService = bookService;
        }

        // GET: /<controller>/
        public IActionResult Detail(int id)
        {
            ViewData["GetAllBookOfCategory"] = _bookService.GetAllBookOfCategory(id);
            ViewData["list1"] = _bookService.GetCountCategory();
            var books = _bookService.ListAllBooks();

            return View(books);
        }
        
    }
}
