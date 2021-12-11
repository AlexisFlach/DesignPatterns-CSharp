using System;

namespace OpenClosed
{   

    // Specification Pattern
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == _size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first, _second;


        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }
        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }


    public class FilterProducts : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            List<Product> filteredProducts = new List<Product>() { };
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                {
                    filteredProducts.Add(item);
                }

            }
            return filteredProducts;
        }
    }
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }


    public class Products
    {
        public static void Run()
        {
            Product product1 = new Product("T-shirt Blue Medium", Color.Blue, Size.Medium);
            Product product2 = new Product("T-shirt Green Medium ", Color.Green, Size.Medium);
            Product product3 = new Product("T-shirt Red Large", Color.Red, Size.Large);
            Product product4 = new Product("T-shirt Blue Large", Color.Blue, Size.Large);

            Product[] boughtProducts = { product1, product2, product3, product4 };
            var filter = new FilterProducts();

            var filteredLargeProducts = filter.Filter(boughtProducts, new SizeSpecification(Size.Large));
            foreach (var p in filteredLargeProducts)
            {
                Console.WriteLine(p.Name);
            }
            var filteredLargeAndBlueProducts = filter.Filter(boughtProducts, new AndSpecification<Product>(
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
            ));

            foreach (var p in filteredLargeAndBlueProducts)
            {
                Console.WriteLine(p.Name);
            }

        }

    }
}