class Customer {
    private string _name;
    private Address _address;

    public Customer(string custName, Address custAddress) {
        _name = custName;
        _address = custAddress;
    }

    public string GetName() {
        return _name;
    }

    public string GetAddress() {
        return _address.GetFullAddress();
    }

    public bool IsInUSA() {
        return _address.IsInUSA();
    }
} 