namespace ModeloAPI.Model
{
    public interface IColaboradorRepository
    {
        void add(Colaborador colaborador);
        List<Colaborador> GetAll();
    }
}
