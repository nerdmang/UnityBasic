using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Textscript : MonoBehaviour
{
    public TextMeshProUGUI text; // �ؽ�Ʈ�� ���� ��
    [SerializeField] TMP_InputField two_box; //��� �ؽ�Ʈ�� ������ ����

    public void OnClickButton()
    {
        text.text = two_box.text;
    }
}
