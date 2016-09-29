namespace BestOfBrands.tenta
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(string name, string password, string email)
        {
            var user = new User
            {
                Name = name,
                Password = password,
                Email = email
            };

            return user;
        }

        public void DeleteUser(string email)
        {
            //todo delete user from db            
        }
    }
}