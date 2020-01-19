using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    private List<Command> commands = new List<Command>();
    private int currentCommand;
    public void ExecuteCommand(Command command)
    {

        commands.Add(command);
        command.Execute();
        currentCommand = commands.Count - 1;
    }
    public void Undo()
    {
        if (currentCommand < 0)
            return;
        commands[currentCommand].Undo();
        commands.RemoveAt(currentCommand);
        currentCommand--;
    }
    public void Redo()
    {
        commands[currentCommand].Execute();
        currentCommand++;
    }
}
