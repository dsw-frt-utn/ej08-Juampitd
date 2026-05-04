namespace Dsw2026Ej8
{
    public class Product
    {
        private string _description;

        public Product(string description)
        {
            _description = description;
        }

        public void UpdateDescription(string newDescription)
        {
            _description = newDescription;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}