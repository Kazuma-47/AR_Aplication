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
        ProcessAnswer(_answer.ToLower());
    }

    private void ProcessAnswer(string answer)
    {
        if (answer == "abc") answer = "123";
        else if (answer == "hello") answer = "bye";
        outputField.text = answer;
    }
}
