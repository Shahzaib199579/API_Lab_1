namespace API_Interactive_Lab_1.Models
{
    public class Coffee
    {
        public Coffee()
        {
            Id = -1;
            Name = "Latte";
        }

        public Coffee(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Id = -1;
                Name = "Latte";
            }
            else
            {
                Id = 1;
                Name = name;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
