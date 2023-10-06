using System;

namespace KB11889_BlazorWasmApp1.Data;

public class CustomersAndProductsDataService
{
    private Customer[]? _customers = null;
    private ColumnConfiguration[]? _customersColumnConfigurations = null;

    private Product[]? _products = null;
    private ColumnConfiguration[]? _productsColumnConfigurations = null;

    public CustomersAndProductsDataService()
    {
    }

    public Task<(Customer[], ColumnConfiguration[])> GetCustomersAndConfigurationsAsync()
    {
        if (this._customers == null)
        {
            this._customers = new List<Customer>()
            {
                new Customer() {ID = "001", FamilyName = "田沢", GivenName = "泰三", Prefecture = "新潟県", City = "新潟市西蒲区"},
                new Customer() {ID = "002", FamilyName = "玉木", GivenName = "裕美子", Prefecture = "宮城県", City = "登米市"},
                new Customer() {ID = "003", FamilyName = "稲垣", GivenName = "幸男", Prefecture = "鳥取県", City = "八頭郡八頭町"},
                new Customer() {ID = "004", FamilyName = "石橋", GivenName = "幸春", Prefecture = "福井県", City = "越前市"},
                new Customer() {ID = "005", FamilyName = "小柳", GivenName = "穂香", Prefecture = "大分県", City = "豊後大野市"},
            }.ToArray<Customer>();
        }

        if (this._customersColumnConfigurations == null)
        {
            this._customersColumnConfigurations = new ColumnConfiguration[]
            {
                new() { PropertyName = "ID", DisplayText = "ID" },
                new() { PropertyName = "FamilyName", DisplayText = "姓" },
                new() { PropertyName = "GivenName", DisplayText = "名" },
                new() { PropertyName = "Prefecture", DisplayText = "県" },
                new() { PropertyName = "City", DisplayText = "市" }
            };
        }

        return Task.FromResult((this._customers, this._customersColumnConfigurations));
    }

    public Task<(Product[], ColumnConfiguration[])> GetProductsAndConfigurationsAsync()
    {
        if (this._products == null)
        {
            this._products = new List<Product>()
            {
                new() { ID = 0, ProductName = "えんぴつ", StockedAmount = 90},
                new() { ID = 1, ProductName = "消しゴム", StockedAmount = 30},
                new() { ID = 2, ProductName = "定規", StockedAmount = 150},
            }.ToArray();
        }

        if (this._productsColumnConfigurations == null)
        {
            this._productsColumnConfigurations = new ColumnConfiguration[]
            {
                new() { PropertyName = "ID", DisplayText = "ID" },
                new() { PropertyName = "ProductName", DisplayText = "製品名" },
                new() { PropertyName = "StockedAmount", DisplayText = "在庫数" },
            };
        }

        return Task.FromResult((this._products, this._productsColumnConfigurations));
    }
}
