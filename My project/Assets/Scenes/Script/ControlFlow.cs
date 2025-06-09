using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    private void Awake()
    {
        count = 0;
    }

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("반복문이 실행됐어요~:)");
        }
    }

    // Start is called before the first frame update
    //void Start()
    public void Gacha()
    {
        //확률이 10% 면 로그에 '김한나'를 뽑았다!
        //확률이 20% 면 로그에 '무야'를 뽑았다!
        //나머지 70% 확률로 '호야'를 뽑았다!

        int randomValue = Random.Range(1, 101); // 1이상 100 미만의 랜덤한 값을 받아 오겠다 (1~100)

        Debug.Log($"랜덤한 값은{randomValue}입니다");

        if (8 <= count)
        {
            count = 0;
            Debug.Log("확정으로 '무야호'를 뽑았다!");
        }

        if (randomValue <= 5)
        {
            Debug.Log("'무야호'를 뽑았다!");
        }
        else if (randomValue <= 15)
        {
            Debug.Log("'무야'를 뽑았다!");
        }
        else if (randomValue <= 30)
        {
            Debug.Log("'무야의 조각'10개를 얻었다!");
        }
        else if (randomValue <= 50)
        {
            Debug.Log("'호야'를 뽑았다!");
        }
        else
        {
            Debug.Log("'호야의 조각'10개를 얻었다!");
        }

        count++;

        switch (randomValue)
        {
            case 1: // 1~10
                Debug.Log("무야호를 뽑았다!");
                break;
        }
    }
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    break;
                }
        }
    }
}