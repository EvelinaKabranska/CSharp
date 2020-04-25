namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] people = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var peopleFill = new List<Person>();
            
            foreach (var perosn in people)
            {
                var personSp = perosn.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = personSp[0];
                decimal money = decimal.Parse(personSp[1]);
                
                try
                {
                    Person some = new Person(name, money, new List<Product>());
                    peopleFill.Add(some);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                

            }
            string[] product = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var products = new List<Product>();
            foreach (var item in product)
            {
                var itemSp = item.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameProduct = itemSp[0];
                decimal cost = decimal.Parse(itemSp[1]);
               
                try
                {
                    Product someProduct = new Product(nameProduct, cost);
                    products.Add(someProduct);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                
            }

            string command = string.Empty;

            while ((command= Console.ReadLine())!="END")
            {
                string[] comSp = command.Split().ToArray();

                string nameOfPerson = comSp[0];
                string prodBuy = comSp[1];


                Person personB = peopleFill.Where(p => p.Name == nameOfPerson).First();
                Product productB = products.Where(p => p.Name == prodBuy).First();

                if(personB.Money>=productB.Cost)
                {
                    personB.Money -= productB.Cost;
                    personB.AddProductToBag(productB);
                    Console.WriteLine("{0} bought {1}", personB.Name, productB.Name);
                }
                else
                {
                    Console.WriteLine("{0} can't afford {1}", personB.Name, productB.Name);
                }
            }
            foreach (Person man in peopleFill )
            {
                if (man.SeeBag().Count()>0)
                {
                    Console.WriteLine("{0} - {1}", man.Name, String.Join(", ", man.SeeBag().Select(p => p.Name)));
                }
                else
                {
                    Console.WriteLine("{0} - Nothing bought", man.Name);
                }


            }

        }
    }
}