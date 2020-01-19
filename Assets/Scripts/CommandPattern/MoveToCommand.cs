using UnityEngine;
internal class MoveToCommand: Command
{
    private Vector3 destination;
    private Vector3 originalPosition;

    public MoveToCommand(IEntity entity, Vector3 destination ): base(entity)
    {
        this.destination = destination;
    }
    public override void Execute()
    {
        originalPosition = entity.transform.position;
        entity.MoveFromTo(originalPosition, destination);
            
    }
    public override void Undo()
    {
        entity.MoveFromTo(entity.transform.position, originalPosition);
    }
}