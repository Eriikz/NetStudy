namespace TestProject1.Moq
{
    public class UserService
    {
        public IUserRepository @object;

        public UserService(IUserRepository @object)
        {
            this.@object = @object;
        }

        public object GetUserById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}