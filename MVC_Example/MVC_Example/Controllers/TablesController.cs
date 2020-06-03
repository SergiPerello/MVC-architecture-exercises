using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Example.Controllers
{
    public class TablesController : Controller
    {
        [Route("/Random/{size}")]
        public IActionResult Random(int size)
        {
            int[,] table = new int[size,size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i,j] = random.Next(1,10);
                }
            }
            ViewBag.tableSize = size;
            ViewBag.tableContent = table;
            return View("Show");
        }

        [Route("/Diagonal/{size}")]
        public IActionResult Diagonal(int size)
        {
            int[,] table = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    table[j, j + i] = i + 1;
                    table[j + i, j] = i + 1;
                }
            }
            ViewBag.tableSize = size;
            ViewBag.tableContent = table;
            return View("Show");
        }
    }
}