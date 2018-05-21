
namespace Task4
{
    public class Human
    {
        string Name { get; set; }
        string Surname { get; set; }
        public int Age { get; set; }

        public Human(string paramName, string paramSurname, int paramAge)
        {
            if (paramName.Length == 0)
            {
                throw new System.FormatException();
            }
            Name = paramName;
            if (paramSurname.Length == 0)
            {
                throw new System.FormatException();
            }
            Surname = paramSurname;
            if (paramAge <= 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            Age = paramAge;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n"
                +$"Surname: {Surname}\n"
                +$"Age: {Age}\n";
        }
    }
}
