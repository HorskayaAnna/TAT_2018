namespace DEVTask7
{
    /// <summary>
    /// Class which create Lada class's object
    /// </summary>
    class LadaBuilder : ProductBuilder
    {
        public override Product Create()
        {
            return new Lada();
        }
    }
}