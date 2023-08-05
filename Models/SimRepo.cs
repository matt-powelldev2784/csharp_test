using Real_Digital_Sim_Stock.Models;

public class SimRepo : ISimRepo
{
    private List<Sim> sims;

    public SimRepo()
    {
        sims = new List<Sim>();
        // Add some dummy data
        sims.Add(new Sim { Ssn = 123456789, SupplierName = "Supplier1", IsActivated = true });
        sims.Add(new Sim { Ssn = 987654321, SupplierName = "Supplier2", IsActivated = false });
    }

    public List<Sim> GetAll()
    {
        return sims;
    }

    public void Add(Sim sim)
    {
        sims.Add(sim);
    }
}
