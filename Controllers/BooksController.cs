using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataRepository.Client.Models;
using DataRepository.Data;

namespace DataRepository.Client.Controllers
{
    public class BooksController : Controller
    {
        private readonly IFacade<Book, BookViewModel> _facade;
        public BooksController(IFacade<Book, BookViewModel> facade)
        {
            _facade = facade;
        }

        public IActionResult Index()
        {
            return View(_facade.GetList());

            //Get filtering with lambda
            //return View(_facade.GetList(b => b.Name.Contains("conhec")));

            //Get filterin with lambda with pagination
            //PageEntity pe = new PageEntity() { ActualPage = 0, PageSize = 50 };
            //return View(_facade.GetListPaged(b => b.Name.StartsWith("co"), pe));
        }

        public async Task<IActionResult> Add(BookViewModel viewModel)
        {
            viewModel = await _facade.Add(viewModel, true);
            return View(viewModel);
        }

        public async Task<IActionResult> Update(BookViewModel viewModel)
        {
            viewModel = await _facade.Update(viewModel, true);
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(BookViewModel viewModel)
        {
            await _facade.Delete(b => b.Id == viewModel.Id);
            return View(viewModel);
        }

    }
}