namespace Patient_Clinic.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }

        public string Injury { get; set; }
        public Patient(int id, string name, string? address, int age, string injury)
        {
            Injury = injury;
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }
        public void update(string name, string address, int age, string injury)
        {
            this.Name = name;
            this.Address = address;
            this.Age = age;
            this.Injury = injury;

        }
    }
}
