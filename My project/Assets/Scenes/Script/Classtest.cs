using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Classtest : MonoBehaviour
{

    public TextMeshProUGUI infoText;

    public string myName = "김한나";
    public string birthDate = "2000-02-21";
    public int age = 26;
    public float height = 166.8f;
    public string mbti = "ISTP";
    public char bloodType = 'B';
    public string ww = "게임, 노래듣기";
    public bool Cat = true;
    public string favoriteColor = "빨간색";

    public void PrintName()
    {
        infoText.text = "이름은 " + myName;
    }

    public void PrintBirthDate()
    {
        infoText.text = "생년월일은 \n" + birthDate;
    }

    public void PrintAge()
    {
        infoText.text = "나이는 " + age + "세";
    }

    public void PrintHeight()
    {
        infoText.text = "키는 " + height + "cm";
    }

    public void PrintMBTI()
    {
        infoText.text = "MBTI는 " + mbti;
    }

    public void PrintBloodType()
    {
        infoText.text = "혈액형은 " + bloodType;
    }

    public void PrintHobbies()
    {
        infoText.text = "취미는 " + ww ;
    }

    public void PrintHasCat()
    {
        infoText.text = "고양이를 키우고 있나요? " + (Cat ? "네!" : "아니요.");
    }

    public void PrintFavoriteColor()
    {
        infoText.text = "좋아하는 색은 " + favoriteColor;
    }
}