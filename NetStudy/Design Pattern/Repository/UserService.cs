using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Repository
{
    // Exemplo de uso do repositório
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.Add(user);
            // Lógica de negócio adicional, se necessário
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
            // Lógica de negócio adicional, se necessário
        }

        // Outros métodos de negócio que utilizam o repositório, se necessário
    }
}
