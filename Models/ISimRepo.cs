using Real_Digital_Sim_Stock.Models;

public interface ISimRepo
{
    List<Sim> GetAll();
    void Add(Sim sim);
}
