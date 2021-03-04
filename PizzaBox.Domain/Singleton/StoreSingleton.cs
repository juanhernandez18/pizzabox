using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singleton
{
    public class StoreSingleton
    {
        public List<AStore> Stores { get; set; }

        public StoreSingleton()
        {
            Stores = new List<AStore>
            {
                new FreddysPizza(),
                new JuansPizza()
            };
        }
    }
}