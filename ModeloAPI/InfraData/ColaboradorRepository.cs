using ModeloAPI.Model;

namespace ModeloAPI.InfraData
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void add(Colaborador colaborador)
        {
            _context.Colaboradores.Add(colaborador);
            _context.SaveChanges();
        }

        public List<Colaborador> GetAll()
        {
            return _context.Colaboradores.ToList();
        }
    }
}
