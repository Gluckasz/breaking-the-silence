using UnityEngine;

public interface DialogueDisplay
{
    public void ToggleDisplay(bool active);
    public void ToggleNextButton(bool active);
    public void DisplayData(DialogueNode dialogueNode);
    public void SetDialogueIterator(DialogueIterator dialogueIterator);
    public DialogueIterator GetDialogueIterator();
}
