namespace BestOfBrands.tenta
{
    //A.Skapa en klass ”User” med tre egenskaper ”Name”, ”Password”, ”Email”. Skapa också en klass ”UserRepository” som implementerar interfacet ”IUserRepository”.
    //B.Interfacet ska ha två metoder ”CreateUser” och ”DeleteUser”. Metoden CreateUser har inparametrarna ”name”, ”password”, ”email” och ska returnera en User.Metoden DeleteUser har inparametern ”email” och returnerar ingenting.
    //C.Skriv kod som skapar upp en user och därefter raderar samma user, du måste använda interfacet. Notera att DeleteUser faktiskt inte raderar usern ännu.
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}