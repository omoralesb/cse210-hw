class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int puantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = puantity; 
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double GetTotalPrice()
        {
            return _price * _quantity;
        }
    }