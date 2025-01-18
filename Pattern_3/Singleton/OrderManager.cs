using Pattern_3.Prototype.ConcretePrototypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Singleton
{
    public class OrderManager
    {
        private static OrderManager _instance;
        private static readonly object _lock = new object();
        private List<Order> _orders;

        private OrderManager()
        {
            _orders = new List<Order>();
        }

        public static OrderManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new OrderManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }
    }
}
