using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //태양광 효율
    public TMP_InputField inputField1;
    //일사량
    public TMP_InputField inputField2;
    //면적
    public TMP_InputField inputField3;
    //결과값
    public TMP_InputField resultText;
    //계산실행버튼
    public Button calculateButton;

    private void Start()
    {
        inputField1.Select();
        inputField2.Select();
        inputField3.Select();
        // Button에 클릭 이벤트 추가
        calculateButton.onClick.AddListener(OnCalculateButtonClick);
    }

    private void OnCalculateButtonClick()
    {
        float value1 = float.Parse(inputField1.text);
        float value2 = float.Parse(inputField2.text);
        float value3 = float.Parse(inputField3.text);

        float result = value1 * value2 * value3;

        // 결과를 TextMeshPro Text에 표시
        resultText.text = result.ToString();
    }
}