using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car                 {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        //img = "/img/tesla.jpg"
                        img = "https://110km.ru/attachment/9bef71e81d7da1df881ba957df2e12187a480b2f/6720421acca7ce1cef1cdee2dd3ca9a7.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCAtegories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://imarka.ru/user/catalog/models/55610.jpg",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category =  _categoryCars.AllCAtegories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://cimg0.ibsrv.net/ibimg/hgm/1920x1080-1/100/470/2015-bmw-m3_100470532.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCAtegories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://hdpic.club/uploads/posts/2021-11/1638293063_5-hdpic-club-p-mersedes-bents-s-klass-6.jpg",
                        price = 65000,
                        isFavorite = false,
                        available = false,
                        Category =  _categoryCars.AllCAtegories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://auto.vercity.ru/img/magazine/2017/10/05/1507214459.jpg",
                        price = 14000,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCAtegories.First()
                    },
                };
            }
        }
                
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
