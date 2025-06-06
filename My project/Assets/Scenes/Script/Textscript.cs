using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Textscript : MonoBehaviour
{
    public TextMeshProUGUI text; // 텍스트를 넣을 곳
    [SerializeField] TMP_InputField two_box; //어디 텍스트를 가지고 올지

    public void OnClickButton()
    {
        text.text = two_box.text;
    }
}
