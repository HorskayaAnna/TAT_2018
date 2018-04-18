namespace DEVTask8
{
    /// <summary>
    /// Class, which contains information about human 
    /// </summary>
    public class Human  
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Human(string paramFirstName, string paramLastName, string paramSex, int paramAge)
        {
            FirstName = paramFirstName;
            LastName = paramLastName;
            Sex = paramSex;
            Age = paramAge;
        }
    }
}
