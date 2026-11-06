using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEventExample
{

    public class OrderEventArgs : EventArgs
    { 
    
        public int OrderID { get; }
        public int OrderTotalPrice { get; }
        public string ClientEmail { get; }
    
        public OrderEventArgs(int OrderID, int OrderTotalPrice, string ClientEmail)
        {
            this.OrderID = OrderID;
            this.OrderTotalPrice = OrderTotalPrice;
            this.ClientEmail = ClientEmail; 

        }

    }


    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;

        public void createOrder(int OrderID , int OrderTotalPrice,string ClientEmail)
        {
            Console.WriteLine("New Order Created , now will notify everyone by raising the event \n");
            if(OnOrderCreated != null)
            {
                OnOrderCreated(this, new OrderEventArgs(OrderID, OrderTotalPrice, ClientEmail));
            }

        }


    


    }



    public class EmailService
    {

        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }

        public void HandleNewOrder(object sender , OrderEventArgs e)
        {

            Console.WriteLine($"--------Email Service -------- ");
            Console.WriteLine($"Email Service Object Received a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Orider Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an email");
            Console.WriteLine($"----------------------------------------");


        }







    }

    public class SMSservice
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }

        public void HandleNewOrder(object sender, OrderEventArgs e)
        {

            Console.WriteLine($"--------SMS Service -------- ");
            Console.WriteLine($"SMS Service Object Received a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Orider Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an email");
            Console.WriteLine($"----------------------------------------");


        }
    }


    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }

        public void HandleNewOrder(object sender, OrderEventArgs e)
        {

            Console.WriteLine($"--------Shipping Service -------- ");
            Console.WriteLine($"Shipping  Service Object Received a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Orider Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an email");
            Console.WriteLine($"----------------------------------------");


        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            var order = new Order();

            EmailService emailService = new EmailService();
            SMSservice SMSservice = new SMSservice();
            emailService.Subscribe(order);
            SMSservice.Subscribe(order);

            order.createOrder(925551, 850, "Ammar@ex.com");


            emailService.UnSubscribe(order);


            order.createOrder(22551, 1850, "Am2zxcar@ex.com");












        }
    }
}
