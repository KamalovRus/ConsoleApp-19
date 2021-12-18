using System;
using System.Collections.Generic;
using System.Linq;

namespace Task19
{
    class Program
    {
        static List<ComputerModel> computers = new List<ComputerModel>();
        static void Main(string[] args)
        {
            computers.Add(new ComputerModel { Code = "1", Brand = "Dell", Processor = "Intel", ProcessorFreq = 2.7, RAM = 8, HDD = 488, GPUMemory = 3, Cost = 15000, AmountAvailable = 10 });
            computers.Add(new ComputerModel { Code = "2", Brand = "DNS", Processor = "Intel", ProcessorFreq = 1.8, RAM = 4, HDD = 488, GPUMemory = 6, Cost = 10000, AmountAvailable = 1 });
            computers.Add(new ComputerModel { Code = "3", Brand = "Lenovo", Processor = "Radeon", ProcessorFreq = 2.2, RAM = 8, HDD = 488, GPUMemory = 6, Cost = 35000, AmountAvailable = 15 });
            computers.Add(new ComputerModel { Code = "4", Brand = "HP", Processor = "Intel", ProcessorFreq = 3.2, RAM = 12, HDD = 1208, GPUMemory = 3, Cost = 10000, AmountAvailable = 3 });
            computers.Add(new ComputerModel { Code = "5", Brand = "Apple", Processor = "Radeon", ProcessorFreq = 1.8, RAM = 8, HDD = 2048, GPUMemory = 3, Cost = 1000000, AmountAvailable = 100 });
            computers.Add(new ComputerModel { Code = "6", Brand = "Microsoft", Processor = "Intel", ProcessorFreq = 2.2, RAM = 8, HDD = 248, GPUMemory = 8, Cost = 25000, AmountAvailable = 55 });
            //задание 1
            Console.WriteLine("Введите название процессора");
            string procName = Console.ReadLine();
            var str = computers.Where(x => x.Processor == procName);
            if (!str.Any())
            {
                Console.WriteLine("Компьютеров с таким процессором не найдено");
            }
            foreach (var item in str)
            {
                Console.WriteLine($"Компьютер: {item.Brand}, процессор: {item.Processor}");
            }
            //задание 2
            Console.WriteLine("\nВведите RAM");
            int ram = int.Parse(Console.ReadLine());
            var str2 = computers.Where(x => x.RAM >= ram);
            if (!str2.Any())
            {
                Console.WriteLine("Компьютеров с таким c RAM больше указанного значения не найдено");
            }
            foreach (var item in str2)
            {
                Console.WriteLine($"Компьютер: {item.Brand}");
            }
            //задание 3
            Console.WriteLine("\nСписок отсортированный по увеличению стоимости");
            var str3 = computers.OrderBy(x => x.Cost);
            foreach (var item in str3)
            {
                Console.WriteLine($"Компьютер: {item.Brand}, стоиомость: {item.Cost}");
            }
            //задание 4
            Console.WriteLine("\nСписок сгруппированный по типу процессора");
            var computerGroups = computers.GroupBy(x => x.Processor);
            foreach (var group in computerGroups)
            {
                foreach (var item in group)
                {
                    Console.WriteLine($"Компьютер: {item.Brand}, процессор: {item.Processor}");
                }

            }
            //задание 5
            var cheapest = computers.OrderBy(x => x.Cost).FirstOrDefault();
            var expensive = computers.OrderBy(x => x.Cost).LastOrDefault();
            Console.WriteLine($"\nСамый дешевый компьютер: {cheapest.Brand}, стоимость: {cheapest.Cost}");
            Console.WriteLine($"Самый дорогой компьютер: {expensive.Brand}, стоимость: {expensive.Cost}");
            //задание 6
            Console.WriteLine();
            var computers2 = computers.Any(x => x.AmountAvailable >= 30);
            if (computers2)
            {
                Console.WriteLine("Да, есть компьютеры количеством не менее 30");
            }
            else
            {
                Console.WriteLine("Нет компьютеров колчеством не менее 30");
            }
        }
    }
    class ComputerModel
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public double ProcessorFreq { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int GPUMemory { get; set; }
        public int Cost { get; set; }
        public int AmountAvailable { get; set; }
    }
}

