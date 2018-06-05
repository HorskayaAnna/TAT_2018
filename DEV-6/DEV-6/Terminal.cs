namespace DEVTask6
{
    class Terminal
    {
        private ICommand commander;
        
        public void SetCommand(ICommand paramCommander)
        {
            this.commander = paramCommander;
        }

        public void Execute()
        {
            if (commander != null)
            {
                commander.Execute();
            }
        }
    }
}
