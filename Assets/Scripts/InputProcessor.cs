using TMPro;
using UnityEngine;

public class InputProcessor : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    private string _answer;
    [SerializeField] private TextMeshProUGUI outputField;

    public void ProcessAnswerFailNet()
    {
        Debug.Log(inputField.text);//the input
        if (inputField.text == null) return;
        _answer = inputField.text;
        ProcessAnswer(_answer);
    }

    private void ProcessAnswer(string answer)
    {
        //Decode het op de manier
        outputField.text = answer;
    }
}
