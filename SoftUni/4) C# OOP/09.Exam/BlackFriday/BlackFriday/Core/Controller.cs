namespace BlackFriday.Core
{
    using Models;
    using Contracts;
    using System.Text;
    using Models.Contracts;
    using Utilities.Messages;
    using System.Linq;

    public class Controller : IController
    {
        private readonly IApplication _application;

        public Controller()
        {
            _application = new Application();
        }

        public string RegisterUser(string userName, string email, bool hasDataAccess)
        {
            IUser? user = null;
            var message = string.Empty;

            if (_application.Users.Exists(userName))
            {
                message = string.Format(OutputMessages.UserAlreadyRegistered, userName);
                return message;
            }

            if (_application.Users.Models.Any(x => x.Email == email))
            {
                message = string.Format(OutputMessages.SameEmailIsRegistered, email);
                return message;
            }

            if (hasDataAccess)
            {
                var adminCount = _application.Users.Models.Count(x => x.GetType().Name == nameof(Admin));

                if (adminCount < 2)
                {
                    user = new Admin(userName, email);
                    _application.Users.AddNew(user);
                    message = string.Format(OutputMessages.AdminRegistered, userName);
                    return message;
                }

                message = string.Format(OutputMessages.AdminCountLimited);
                return message;

            }

            user = new Client(userName, email);
            _application.Users.AddNew(user);
            message = string.Format(OutputMessages.ClientRegistered, userName);
            return message;
        }

        public string AddProduct(string productType, string productName, string userName, double basePrice)
        {
            IProduct product = null;
            var message = string.Empty;

            if (productType != nameof(Item) && productType != nameof(Service))
            {
                message = string.Format(OutputMessages.ProductIsNotPresented, productType);
                return message;
            }

            if (_application.Products.Exists(productName))
            {
                message = string.Format(OutputMessages.ProductNameDuplicated, productName);
                return message;
            }

            if (!_application.Users.Exists(userName) || _application.Users.GetByName(userName).GetType().Name == nameof(Client))
            {
                message = string.Format(OutputMessages.UserIsNotAdmin, userName);
                return message;
            }

            if (productType == nameof(Item))
            {
                product = new Item(productName, basePrice);
            }
            else if (productType == nameof(Service))
            {
                product = new Service(productName, basePrice);
            }

            _application.Products.AddNew(product);
            message = string.Format(OutputMessages.ProductAdded, productType, productName, basePrice);
            return message;
        }

        public string UpdateProductPrice(string productName, string userName, double newPriceValue)
        {
            var message = string.Empty;

            if (!_application.Products.Exists(productName))
            {
                message = string.Format(OutputMessages.ProductDoesNotExist, productName);
                return message;
            }

            if (!_application.Users.Exists(userName) || _application.Users.GetByName(userName).GetType().Name == nameof(Client))
            {
                message = string.Format(OutputMessages.UserIsNotAdmin, userName);
                return message;
            }

            var product = _application.Products.GetByName(productName);

            message = string.Format(OutputMessages.ProductPriceUpdated, productName, product.BasePrice, newPriceValue);
            product.UpdatePrice(newPriceValue);
            return message;
        }

        public string RefreshSalesList(string userName)
        {
            var message = string.Empty;

            if (!_application.Users.Exists(userName) || _application.Users.GetByName(userName).GetType().Name == nameof(Client))
            {
                message = string.Format(OutputMessages.UserIsNotAdmin, userName);
                return message;
            }

            var availableProducts = _application.Products.Models.Where(x => x.IsSold);
            message = string.Format(OutputMessages.SalesListRefreshed, availableProducts.Count());

            foreach (var availableProduct in availableProducts)
            {
                availableProduct.ToggleStatus();
            }

            return message;
        }

        public string PurchaseProduct(string userName, string productName, bool blackFridayFlag)
        {
            var message = string.Empty;

            if (!_application.Users.Exists(userName) || _application.Users.GetByName(userName).GetType().Name == nameof(Admin))
            {
                message = string.Format(OutputMessages.UserIsNotClient, userName);
                return message;
            }

            if (!_application.Products.Exists(productName))
            {
                message = string.Format(OutputMessages.ProductDoesNotExist, productName);
                return message;
            }

            var product = _application.Products.GetByName(productName);

            if (_application.Products.Exists(productName) && product.IsSold)
            {
                message = string.Format(OutputMessages.ProductOutOfStock, productName);
                return message;
            }

            var user = _application.Users.GetByName(userName) as Client;
            user.PurchaseProduct(productName, blackFridayFlag);
            product.ToggleStatus();

            if (blackFridayFlag)
            {
                message = string.Format(OutputMessages.ProductPurchased, userName, productName, product.BasePrice);
            }

            message = string.Format(OutputMessages.ProductPurchased, userName, productName, product.BasePrice - product.BlackFridayPrice);
            return message;
        }

        public string ApplicationReport()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Application administration:");
            foreach (var model in _application.Users.Models.OrderBy(x => x.UserName))
            {
                if (model.GetType().Name == nameof(Admin))
                {
                    sb.AppendLine(model.ToString()); 
                }
            }

            sb.AppendLine("Clients:");
            foreach (var model in _application.Users.Models.OrderBy(x => x.UserName))
            {
                if (model.GetType().Name == nameof(Client))
                {
                    sb.AppendLine(model.ToString());

                    var client = _application.Users.Models.FirstOrDefault(x => x.UserName == model.UserName) as Client;

                    if (client.Purchases.Any())
                    {
                        foreach (var purchaseProduct in client.Purchases)
                        {
                            sb.AppendLine(purchaseProduct.Key);
                        }
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}