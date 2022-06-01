using UnityEngine;
using UnityEngine.Events;


public class ButtonInteraction : InteractionBehaviour
{
    [SerializeField] private UnityEvent<int> onButtonPressed = new UnityEvent<int>();

    [SerializeField] private int buttonValue;
    //[SerializeField] private UnityEvent onButtonPressed = new UnityEvent();
    public override void Run()
    {
        onButtonPressed?.Invoke(buttonValue);
    }
    
        
    
}
