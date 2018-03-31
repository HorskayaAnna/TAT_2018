namespace DEVTask7
{
    /// <summary>
    /// Class which create peugeot class's object
    /// </summary>
    class PegueotBuilder : ProductBuilder
    {       
        public override Product Create()
        {
            return new Peugeot();
        }
    }
}