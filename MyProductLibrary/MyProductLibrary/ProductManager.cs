using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProductLibrary
{
    public class ProductManager
    {
        // Поле для хранения данных
        private Dictionary<string, DateTime> _products = new Dictionary<string, DateTime>();

        // Метод для добавления товара (void)
        public void AddProduct(string name, DateTime date)
        {
            if (!_products.ContainsKey(name))
            {
                _products[name] = date;
                Console.WriteLine($"Товар '{name}' добавлен с датой {date:dd.MM.yyyy}.");
            }
            else
            {
                Console.WriteLine($"Товар '{name}' уже существует.");
            }
        }

        // Метод для удаления товара (void)
        public void RemoveProduct(string name)
        {
            if (_products.Remove(name))
            {
                Console.WriteLine($"Товар '{name}' удалён.");
            }
            else
            {
                Console.WriteLine($"Товар '{name}' не найден.");
            }
        }

        // Метод для получения даты поступления товара (DateTime?)
        public DateTime? GetProductDate(string name)
        {
            if (_products.ContainsKey(name))
            {
                return _products[name]; // Возвращаем дату, если товар существует
            }
            return null; // Возвращаем null, если товара нет
        }

        // Метод для получения общего количества товаров (int)
        public int GetProductCount()
        {
            return _products.Count;
        }

        // Метод для проверки наличия товара (bool)
        public bool HasProduct(string name)
        {
            return _products.ContainsKey(name);
        }
    }
}
