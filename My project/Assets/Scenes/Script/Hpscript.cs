using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hpscript : MonoBehaviour
{
    public Image Image_HP;

    public int MaxHP;
    float nowHP;
    // �ּ�ü���� 0

    public int Damage;
    public int HealPoint;
    public TextMeshProUGUI tx_HP;

    void Awake()
    {
        nowHP = MaxHP;
        Initialize();
    }

    void Initialize() // Initialize()
    {
        RefreshU();
    }

    public void OnClickDamage() // �����
    {
        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }
        RefreshU();
    }

    public void OnClickHeal() // ȸ��
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshU();
    }

    void RefreshU()
    {
        Image_HP.fillAmount = nowHP / MaxHP;
        tx_HP.text = $"{nowHP}/{MaxHP}";
    }

}