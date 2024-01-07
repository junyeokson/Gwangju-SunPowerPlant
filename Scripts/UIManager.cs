using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //�¾籤 ȿ��
    public TMP_InputField inputField1;
    //�ϻ緮
    public TMP_InputField inputField2;
    //����
    public TMP_InputField inputField3;
    //�����
    public TMP_InputField resultText;
    //�������ư
    public Button calculateButton;

    private void Start()
    {
        inputField1.Select();
        inputField2.Select();
        inputField3.Select();
        // Button�� Ŭ�� �̺�Ʈ �߰�
        calculateButton.onClick.AddListener(OnCalculateButtonClick);
    }

    private void OnCalculateButtonClick()
    {
        float value1 = float.Parse(inputField1.text);
        float value2 = float.Parse(inputField2.text);
        float value3 = float.Parse(inputField3.text);

        float result = value1 * value2 * value3;

        // ����� TextMeshPro Text�� ǥ��
        resultText.text = result.ToString();
    }
}