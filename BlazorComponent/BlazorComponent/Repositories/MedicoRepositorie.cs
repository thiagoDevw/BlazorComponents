using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public class MedicoRepositorie : IMedicoRepositories
    {
        public async Task<List<Medico>> GetAllAsync()
        {
            return new List<Medico>
            {
                new Medico{ Id = 1, Name = "Pedro Silva", Crm = "ABC123"},
                new Medico{ Id = 2, Name = "Antonio Garcia", Crm = "fdfs123"},
                new Medico{ Id = 3, Name = "Mateus Costa", Crm = "Ahhhf123"},
                new Medico{ Id = 4, Name = "Alberto Roberto", Crm = "Acvsd123"},
                new Medico{ Id = 5, Name = "Pedro Menezes", Crm = "gsdg123"},
            };
        }
    }
}
