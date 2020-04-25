namespace ShoppingSpree
{
    using System.Collections.Generic;
    using System;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money, List<Product> bagOfProducts)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty.");
                    
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        

        public List<Product> SeeBag()
        {
            return this.bagOfProducts;
        }
        public void AddProductToBag(Product product)
        {
            bagOfProducts.Add(product);
        }
    }
}
