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
            Debug.Log("�ݺ����� ����ƾ��~:)");
        }
    }

    // Start is called before the first frame update
    //void Start()
    public void Gacha()
    {
        //Ȯ���� 10% �� �α׿� '���ѳ�'�� �̾Ҵ�!
        //Ȯ���� 20% �� �α׿� '����'�� �̾Ҵ�!
        //������ 70% Ȯ���� 'ȣ��'�� �̾Ҵ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 100 �̸��� ������ ���� �޾� ���ڴ� (1~100)

        Debug.Log($"������ ����{randomValue}�Դϴ�");

        if (8 <= count)
        {
            count = 0;
            Debug.Log("Ȯ������ '����ȣ'�� �̾Ҵ�!");
        }

        if (randomValue <= 5)
        {
            Debug.Log("'����ȣ'�� �̾Ҵ�!");
        }
        else if (randomValue <= 15)
        {
            Debug.Log("'����'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30)
        {
            Debug.Log("'������ ����'10���� �����!");
        }
        else if (randomValue <= 50)
        {
            Debug.Log("'ȣ��'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ȣ���� ����'10���� �����!");
        }

        count++;

        switch (randomValue)
        {
            case 1: // 1~10
                Debug.Log("����ȣ�� �̾Ҵ�!");
                break;
        }
    }
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    break;
                }
        }
    }
}