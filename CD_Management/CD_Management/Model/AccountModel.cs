namespace CD_Management.Model
{
    public class AccountModel : IModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public AccountModel() { }
        public bool isValidate()
        {
            return true;
        }
    }
}
