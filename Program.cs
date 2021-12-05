using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new();
            LightCommand lightCommand = new(lamp);

            RemoteControl remote = new(lightCommand);
            remote.ExecuteCommand();
            remote.UndoCommand();
        }
    }
}