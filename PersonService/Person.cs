namespace PersonService
{
    public class Person
    {
        public string Firstname {get; set;}
        public string Lastname {get; set;}

        public override string ToString()
        {
            return "Person[firstname=" + Firstname + ", lastname=" + Lastname + "]";
        }
    }
}