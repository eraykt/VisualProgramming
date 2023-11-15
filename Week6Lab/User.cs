namespace Lab6
{
    public class User
    {
        int id;
        string name;
        string surname;
        int age;

        public User(int id, string name, string surname, int age)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetName() => $"{name} {surname}";
        public int GetId() => id;
        public int GetAge() => age;
        public string GetFirstName() => name;
        public string GetSurname() => surname;
        public void SetId(int id) => this.id = id;
    }

}
