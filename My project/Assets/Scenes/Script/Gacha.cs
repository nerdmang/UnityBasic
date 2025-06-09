using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Character
{
    public string name;
    public int probability;
    public Sprite image;
}

public class Gacha : MonoBehaviour
{
    [Header("뽑기용 캐릭터 목록")]
    public List<Character> characterPool = new List<Character>();

    [Header("결과 이미지 슬롯 (최대 10개)")]
    public List<Image> resultImages;

    [Header("UI 텍스트")]
    public TextMeshProUGUI pullLogText;  
    public TextMeshProUGUI noticeText;  

    private int currentPullCount = 0;

    public void PullCharacters(int count)
    {
        noticeText.text = "";
        StartCoroutine(DoPull(count));
    }

    private IEnumerator DoPull(int count)
    {
        ClearImages();

        for (int i = 0; i < count; i++)
        {
            currentPullCount++;
            if (currentPullCount > 100)
                currentPullCount = 1;

            Character result = (currentPullCount == 100)
                ? GetTextureCharacter()
                : GetRandomCharacter();

            if (i < resultImages.Count)
            {
                resultImages[i].sprite = result.image;
                resultImages[i].gameObject.SetActive(true);
                StartCoroutine(PopAnimation(resultImages[i].rectTransform));
            }

            pullLogText.text += $"{result.name} ({currentPullCount})\n";

            yield return new WaitForSeconds(0.15f);
        }
    }

    private Character GetRandomCharacter()
    {
        int total = 0;
        foreach (var c in characterPool)
            total += c.probability;

        int rand = Random.Range(0, total);
        int current = 0;

        foreach (var c in characterPool)
        {
            current += c.probability;
            if (rand < current)
                return c;
        }

        return characterPool[0]; 
    }

    private Character GetTextureCharacter()
    {
        foreach (var c in characterPool)
        {
            if (c.name == "텍스처")
                return c;
        }

        Debug.LogWarning("'텍스처' 캐릭터가 목록에 없습니다.");
        return characterPool[0];
    }

    private void ClearImages()
    {
        foreach (var img in resultImages)
        {
            img.sprite = null;
            img.gameObject.SetActive(false);
            img.rectTransform.localScale = Vector3.one;
        }
    }

    private IEnumerator PopAnimation(RectTransform target)
    {
        Vector3 originalScale = Vector3.one;
        Vector3 popScale = Vector3.one * 1.2f;

        target.localScale = popScale;
        yield return new WaitForSeconds(0.1f);
        target.localScale = originalScale;
    }

    public void ClearLog()
    {
        pullLogText.text = "";
        noticeText.text = "";
        currentPullCount = 0;
    }
}
