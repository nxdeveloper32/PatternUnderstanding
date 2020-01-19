using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CommandProcessor))]
[RequireComponent(typeof(ClickInputReader))]
public class ClickToMoveEntity : MonoBehaviour,IEntity
{
    private CommandProcessor commandProcessor;
    private ClickInputReader clickInputReader;
    private Coroutine coroutine;
    void Awake()
    {
        commandProcessor = GetComponent<CommandProcessor>();
        clickInputReader = GetComponent<ClickInputReader>();
    }

    // Update is called once per frame
    void Update()
    {
        var postion = clickInputReader.GetClickPosition();
        if (postion != null)
        {
            commandProcessor.ExecuteCommand(new MoveToCommand(this, postion.Value));
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            commandProcessor.Undo();
        }
    }
    public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
    {
        if (coroutine != null)
            StopCoroutine(coroutine);
        coroutine = StartCoroutine(MoveFromToAsync(startPosition, endPosition));
    }

    private IEnumerator MoveFromToAsync(Vector3 startPosition, Vector3 endPosition)
    {
        float elapsed = 0;
        while (elapsed < 1f)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsed);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = endPosition;
    }
}
