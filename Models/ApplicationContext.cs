using AutoParts.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParts.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role[]
            {
                new Role { Id = 1, Name = "admin" },
                new Role { Id = 2, Name = "user" }
                });

            modelBuilder.Entity<Entities.User>().HasData(new Entities.User[] {
        new Entities.User
        {
            Id = 1,
            Login = "admin",
            Pass = "admin",
            RoleId = 1
            },
            new User
            {
            Id = 2,
            Login = "user",
            Pass = "user",
            RoleId = 2
            }

            });

            modelBuilder.Entity<Entities.Category>().HasData(new Entities.Category[] {
        new Entities.Category
        {
            Id = 1,
            Name = "Тормозная система",            
            },
        new Entities.Category
        {
            Id = 2,
            Name = "Масла и Автохимия",
            },
        new Entities.Category
        {
            Id = 3,
            Name = "Подвеска и рулевое",
            },
        new Entities.Category
        {
            Id = 4,
            Name = "Электрика и освещение",
            },
        new Entities.Category
        {
            Id = 5,
            Name = "Шины и аккумуляторы",
            },
        });
            modelBuilder.Entity<Entities.Product>().HasData(new Entities.Product[] {
        new Entities.Product
        {
            Id = 1,
            Name = "Аккумулятор",
            Price = 200,
            Amount = 5,
            CountryManufactur = "USA",
            Description = "Номинальная емкость: 55 A/h, Ток разряда: 430 А (EN), Габаритные размеры: 242х175х190 мм",
            CategoryId = 5,
            Image = "/img/1.jpg"
            },
        new Entities.Product
        {
            Id = 2,
            Name = "Свечи зажигания",
            Price = 100,
            Amount = 40,
            CountryManufactur = "Germany",
            Description = "Момент затяжки от 20Нм, Момент затяжки до 30Нм, Наружная резьба 14мм, Расстояние между электродами 1,1, Длина резьбы 19мм, Шаг резьбы 1,25мм",
            CategoryId = 4,
            Image = "/img/2.jpg"
            },
        new Entities.Product
        {
            Id = 3,
            Name = "Диск",
            Price = 20,
            Amount = 51,
            CountryManufactur = "China",
            Description = "Диаметр 14, Ширина 5,5, Разболтовка 4/100,0, Диаметр ЦО 67,1, Вылет (ET) 39",
            CategoryId = 5,
            Image = "/img/3.jpg"
        },
        new Entities.Product
        {
            Id = 4,
            Name = "Пружина",
            Price = 300,
            Amount = 60,
            CountryManufactur = "Russia",
            Description = "Форма: Пружина с постоянным диаметром Вес: 2,1кг, Толщина: 13,5мм Наружный диаметр: 145мм Длина: 215мм",
            CategoryId = 3,
            Image = "/img/4.jpg"
            },
        new Entities.Product
        {
            Id = 5,
            Name = "Моторное масло",
            Price = 100,
            Amount = 15,
            CountryManufactur = "Japan",
            Description = "Вязкость 5W-20, Объем 4L, Производитель MITSUBISHI",
            CategoryId = 2,
            Image = "/img/5.jpg"
        },
        new Entities.Product
        {
            Id = 6,
            Name = "Антифриз",
            Price = 1500,
            Amount = 15,
            CountryManufactur = "Ukraine",
            Description = "Допуск G40, Концентрат Объем 2л,  Производитель COMMA, Цвет Розовый",
            CategoryId = 2,
            Image = "/img/6.jpg"
        },
        new Entities.Product
        {
            Id = 7,
            Name = "Тормозной диск",
            Price = 100,
            Amount = 35,
            CountryManufactur = "Russia",
            Description = "Тип: с внутренней вентиляцией, Диаметр: 330мм Толщина: 28мм Минимальная толщина: 26мм, Высота: 73,5мм, Число отверстий: 5, Вес: 8,6кг",
            CategoryId = 1,
            Image = "/img/7.jpg"
        },
        new Entities.Product
        {
            Id = 8,
            Name = "Тормозные колодки",
            Price = 300,
            Amount = 10,
            CountryManufactur = "Russia",
            Description = "Длина 55,8мм Ширина 53,1мм Толщина 15мм Качество 944, Вес 0.605кг Исполнение моста Front & Rear ",
            CategoryId = 1,
            Image = "/img/8.jpg"
        },
        new Entities.Product
        {
            Id = 9,
            Name = "Щётки стеклоочистителя",
            Price = 20,
            Amount = 100,
            CountryManufactur = "Belarus",
            Description = "Графитовое покрытие, матированный корпус, комплектуются адаптерами для всех автомобилей",
            CategoryId = 1,
            Image = "/img/9.jpg"
        },
        new Entities.Product
        {
            Id = 10,
            Name = "Автолампа",
            Price = 25,
            Amount = 30,
            CountryManufactur = "Japan",
            Description = "Тип ламп: R2(Bilux), Напряжение [В]: 12, Номинальная мощность [Вт]: 45/40, Исполнение патрона: P45t",
            CategoryId = 4,
            Image = "/img/10.jpg"
        },
        new Entities.Product
        {
            Id = 11,
            Name = "Ароматизатор",
            Price = 2,
            Amount = 1000,
            CountryManufactur = "Russia",
            Description = "Бумажный вкладыш пропитан французскими духами и сохраняет морской аромат на протяжении 30 дней.",
            CategoryId = 1,
            Image = "/img/11.jpg"
        },
        new Entities.Product
        {
            Id = 12,
            Name = "Видеорегистратор",
            Price = 800,
            Amount = 10,
            CountryManufactur = "China",
            Description = "Основная камера: 1/2.9, видео 1920x1080 H.264, G-сенсор, экран 3 640 x 360",
            CategoryId = 4,
            Image = "/img/12.jpg"
        }
        }) ;
        }
    }
}
