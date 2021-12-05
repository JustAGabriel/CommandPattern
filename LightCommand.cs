namespace CommandPattern
{
    public class LightCommand : ICommand
    {
        private readonly Lamp _lamp;

        public LightCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void Execute()
        {
            _lamp.TurnOn();
        }

        public void Revert()
        {
            _lamp.TurnOff();
        }
    }
}