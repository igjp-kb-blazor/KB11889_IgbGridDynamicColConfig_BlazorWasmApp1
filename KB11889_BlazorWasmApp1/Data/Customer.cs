namespace KB11889_BlazorWasmApp1.Data;

public class Customer
{
    public String ID { get; set; } = String.Empty;
    public String FamilyName { get; set; } = String.Empty;
    public String GivenName { get; set; } = String.Empty;
    public String Prefecture { get; set; } = String.Empty;
    public String City { get; set; } = String.Empty;

    public Customer()
    {
    }
}