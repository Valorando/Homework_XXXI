using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Нажмите 1 чтобы добавить.");
                    Console.WriteLine("Нажмите 2 чтобы показать.");
                    Console.WriteLine("Нажмите 3 чтобы выйти..");
                    Console.WriteLine("Подсказка: при вводе значений используйте латинские буквы.");
                    Console.WriteLine();
                    ConsoleKeyInfo key_one = Console.ReadKey();

                    if (key_one.Key == ConsoleKey.D1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Что нужно добавить?");
                            Console.WriteLine("Нажмите 1 чтобы добавить пиццу.");
                            Console.WriteLine("Нажмите 2 чтобы добавить клиента.");
                            Console.WriteLine("Нажмите 3 чтобы добавить заказ.");
                            Console.WriteLine("Нажмите 4 чтобы вернуться в гланое меню.");
                            Console.WriteLine();
                            ConsoleKeyInfo key_two = Console.ReadKey();

                            if (key_two.Key == ConsoleKey.D1)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список пицц:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var pizzas = db.Pizzas.ToList();
                                        foreach (var p in pizzas)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Weight + "  " + p.Price);
                                        }
                                    }
                                    Console.WriteLine();
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        Console.Write("Введите название:");
                                        string name = Console.ReadLine();
                                        Console.Write("Введите вес (Пример: 300g):");
                                        string weight = Console.ReadLine();
                                        Console.Write("Введите цену (Пример: 75grn):");
                                        string price = Console.ReadLine();

                                        Pizzas pz = new Pizzas { Name = $"{name}", Weight = $"{weight}", Price = $"{price}" };
                                        db.Pizzas.Add(pz);
                                        db.SaveChanges();
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D2)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список клиентов:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var clients = db.Clients.ToList();
                                        foreach (var p in clients)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Surname + "  " + p.PhoneNumber);
                                        }
                                    }
                                    Console.WriteLine();
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        Console.Write("Введите имя:");
                                        string name = Console.ReadLine();
                                        Console.Write("Введите фамилию:");
                                        string surname = Console.ReadLine();
                                        Console.Write("Введите номер телефона (Без символа +):");
                                        int number = Convert.ToInt32(Console.ReadLine());

                                        Clients cl = new Clients { Name = $"{name}", Surname = $"{surname}", PhoneNumber = number };
                                        db.Clients.Add(cl);
                                        db.SaveChanges();
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D3)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список клиентов:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var clients = db.Clients.ToList();
                                        foreach (var p in clients)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Surname + "  " + p.PhoneNumber);
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список пицц:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var pizzas = db.Pizzas.ToList();
                                        foreach (var p in pizzas)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Weight + "  " + p.Price);
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список заказов:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var orders = db.Orders.ToList();
                                        foreach (var p in orders)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Client_Id + "  " + p.Pizza_Id + "  " + p.Amount_total + "  " + p.Adress);
                                        }
                                    }
                                    Console.WriteLine();
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        Console.Write("Введите Id клиента:");
                                        int client_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Введите Id пицц (Пример: 1,1,3):");
                                        string pizza_id = Console.ReadLine();
                                        Console.Write("Введите сумму заказа (Пример: 350grn):");
                                        string sum = Console.ReadLine();
                                        Console.Write("Введите адрес:");
                                        string adress = Console.ReadLine();

                                        Orders or = new Orders { Client_Id = client_id, Pizza_Id = $"{pizza_id}", Amount_total = $"{sum}", Adress = $"{adress}" };
                                        db.Orders.Add(or);
                                        db.SaveChanges();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D4)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_one.Key == ConsoleKey.D2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Что нужно показать?");
                            Console.WriteLine("Нажмите 1 чтобы показать список пицц.");
                            Console.WriteLine("Нажмите 2 чтобы показать список клиентов.");
                            Console.WriteLine("Нажмите 3 чтобы показать список заказов.");
                            Console.WriteLine("Нажмите 4 чтобы вернуться в гланое меню.");
                            Console.WriteLine();
                            ConsoleKeyInfo key_two = Console.ReadKey();

                            if (key_two.Key == ConsoleKey.D1)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список пицц:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var pizzas = db.Pizzas.ToList();
                                        foreach (var p in pizzas)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Weight + "  " + p.Price);
                                        }
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D2)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список клиентов:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var clients = db.Clients.ToList();
                                        foreach (var p in clients)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Surname + "  " + p.PhoneNumber);
                                        }
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D3)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Текущий список заказов:");
                                    using (PizzaDBEntities db = new PizzaDBEntities())
                                    {
                                        var orders = db.Orders.ToList();
                                        foreach (var p in orders)
                                        {
                                            Console.WriteLine(p.Id + "  " + p.Client_Id + "  " + p.Pizza_Id + "  " + p.Amount_total + "  " + p.Adress);
                                        }
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Ошибка: {ex.Message}");
                                    Console.WriteLine();
                                }
                            }

                            if (key_two.Key == ConsoleKey.D4)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_one.Key == ConsoleKey.D3)
                    {
                        Environment.Exit(0);
                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }
    }
}
