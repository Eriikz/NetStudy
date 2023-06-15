using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Repository
{
    // Exemplo de uso do repositório
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        // Métodos específicos do repositório de usuários, se necessário
        public User GetByEmail(string email)
        {
            return _context.Set<User>().FirstOrDefault(u => u.Email == email);
        }
    }

}
