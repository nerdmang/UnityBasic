using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Classtest : MonoBehaviour
{

    public TextMeshProUGUI infoText;

    public string myName = "���ѳ�";
    public string birthDate = "2000-02-21";
    public int age = 26;
    public float height = 166.8f;
    public string mbti = "ISTP";
    public char bloodType = 'B';
    public string ww = "����, �뷡���";
    public bool Cat = true;
    public string favoriteColor = "������";

    public void PrintName()
    {
        infoText.text = "�̸��� " + myName;
    }

    public void PrintBirthDate()
    {
        infoText.text = "��������� \n" + birthDate;
    }

    public void PrintAge()
    {
        infoText.text = "���̴� " + age + "��";
    }

    public void PrintHeight()
    {
        infoText.text = "Ű�� " + height + "cm";
    }

    public void PrintMBTI()
    {
        infoText.text = "MBTI�� " + mbti;
    }

    public void PrintBloodType()
    {
        infoText.text = "�������� " + bloodType;
    }

    public void PrintHobbies()
    {
        infoText.text = "��̴� " + ww ;
    }

    public void PrintHasCat()
    {
        infoText.text = "����̸� Ű��� �ֳ���? " + (Cat ? "��!" : "�ƴϿ�.");
    }

    public void PrintFavoriteColor()
    {
        infoText.text = "�����ϴ� ���� " + favoriteColor;
    }
}