using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Repository
{
    public class Run
    {
        public void Exibir()
        {
            // Configurar o contexto do banco de dados (DbContext)
            //var dbContext = new DbContext();

            // Instanciar o repositório e o serviço
           // var userRepository = new UserRepository(dbContext);
           // var userService = new UserService(userRepository);

            // Criar um novo usuário
            var newUser = new User { Id = 1, Name = "John Doe", Email = "johndoe@example.com" };
           // userService.CreateUser(newUser);

            // Atualizar um usuário existente
         //   var existingUser = userService.GetUserById(1);
          //  if (existingUser != null)
            //{
            //    existingUser.Name = "Jane Doe";
            //    userService.UpdateUser(existingUser);
            //}

            //// Obter todos os usuários
            //var allUsers = userService.GetAllUsers();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine($"ID: {user.Id}, Nome: {user.Name}, Email: {user.Email}");
            //}
        }
    }
}
