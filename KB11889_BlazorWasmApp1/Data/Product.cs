namespace KB11889_BlazorWasmApp1.Data;

public class Product
{
    public int ID { get; set; }
    public String ProductName { get; set; } = "";
    public int StockedAmount { get; set; }

    public Product()
    {
    }
}
