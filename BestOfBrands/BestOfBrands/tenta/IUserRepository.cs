namespace BestOfBrands.tenta
{
    public interface IUserRepository
    {
        User CreateUser(string name, string password, string email);

        void DeleteUser(string email);
    }
}