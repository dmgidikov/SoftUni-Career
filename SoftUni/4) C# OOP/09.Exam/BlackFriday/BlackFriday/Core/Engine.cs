namespace BlackFriday.Core
{
    using IO;
    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IReader _reader;
        private IWriter _writer;
        private IController _controller;

        public Engine()
        {
            _reader = new Reader();
            _writer = new Writer();
            _controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                string[] input = _reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string result = string.Empty;

                    if (input[0] == "RegisterUser")
                    {
                        string userName = input[1];
                        string email = input[2];
                        string hasDataAccess = input[3];

                        result = _controller.RegisterUser(userName, email, bool.Parse(hasDataAccess));
                    }
                    else if (input[0] == "AddProduct")
                    {
                        string productType = input[1];
                        string productName = input[2];
                        string userName = input[3];
                        double basePrice = double.Parse(input[4]);

                        result = _controller.AddProduct(productType, productName, userName, basePrice);
                    }
                    else if (input[0] == "UpdateProductPrice")
                    {
                        string productName = input[1];
                        string userName = input[2];
                        double newPriceValue = double.Parse(input[3]);

                        result = _controller.UpdateProductPrice(productName, userName, newPriceValue);
                    }
                    else if (input[0] == "RefreshSalesList")
                    {
                        string userName = input[1];

                        result = _controller.RefreshSalesList(userName);
                    }
                    else if (input[0] == "PurchaseProduct")
                    {
                        string userName = input[1];
                        string productName = input[2];
                        string blackFridayFlag = input[3];

                        result = _controller.PurchaseProduct(userName, productName, bool.Parse(blackFridayFlag));
                    }
                    else if (input[0] == "ApplicationReport")
                    {
                        result = _controller.ApplicationReport();
                    }
                    _writer.WriteLine(result);
                    _writer.WriteText(result);
                }
                catch (Exception ex)
                {
                    _writer.WriteLine(ex.Message);
                    _writer.WriteText(ex.Message);
                }
            }
        }
    }
}
