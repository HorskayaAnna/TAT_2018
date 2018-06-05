namespace DEVTask7
{
    /// <summary>
    /// Class, which create's bmw object
    /// </summary>
    class BmwBuilder : ProductBuilder
    {
        public override Product Create()
        {
            return new Bmw();
        }
    }
}