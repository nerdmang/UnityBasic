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
    // 최소체력은 0

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

    public void OnClickDamage() // 대미지
    {
        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }
        RefreshU();
    }

    public void OnClickHeal() // 회복
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