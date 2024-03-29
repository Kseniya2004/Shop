﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCAtegories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category{ categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
