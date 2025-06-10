using UnityEngine;
using TMPro;

public class Star : MonoBehaviour
{
    public GameObject TextBox;
    public TextMeshProUGUI Text;

    public void Phase1()
    {
        TextBox.SetActive(true);
        Text.text = Phase11();
    }

    public void Phase2()
    {
        TextBox.SetActive(true);
        Text.text = Phase22();
    }

    public void Phase3()
    {
        TextBox.SetActive(true);
        Text.text = Phase33();
    }

    public void Phase4()
    {
        TextBox.SetActive(true);
        Text.text = Phase44();
    }

    public void Phase5()
    {
        TextBox.SetActive(true);
        Text.text = Phase55();
    }

    public void Close()
    {
        TextBox.SetActive(false);
    }

    // Phase 1
    public string Phase11()
    {
        string star = "";
        for (int i = 1; i <= 5; i++)
        {
            star += new string('★', i) + "\n";
        }
        return star;
    }

    // Phase 2
    public string Phase22()
    {
        string star = "";
        for (int i = 1; i <= 5; i++)
        {
            string space = new string('　', 5 - i);
            star += space + new string('★', i) + "\n";
        }
        return star;
    }

    // Phase 3
    public string Phase33()
    {
        string star = "";
        int max = 5;

        for (int i = 1; i <= max; i++)
        {
            star += new string('★', i) + "\n";
        }

        for (int i = max - 1; i >= 1; i--)
        {
            star += new string('★', i) + "\n";
        }

        return star;
    }


    // Phase 4: 오른쪽 역삼각형
    public string Phase44()
    {
        string star = "";
        int max = 5;

        for (int i = 1; i <= max; i++)
        {
            string space = new string('　', max - i);
            star += space + new string('★', i) + "\n";
        }

        for (int i = max - 1; i >= 1; i--)
        {
            string space = new string('　', max - i);
            star += space + new string('★', i) + "\n";
        }

        return star;
    }


    // Phase 5
    public string Phase55()
    {
        string star = "";
        int max = 5;

   
        for (int i = 1; i <= max; i++)
        {
            string space = new string('　', max - i); 
            string stars = new string('★', 2 * i - 1);
            star += space + stars + "\n";
        }

        for (int i = max - 1; i >= 1; i--)
        {
            string space = new string('　', max - i);
            string stars = new string('★', 2 * i - 1);
            star += space + stars + "\n";
        }

        return star;
    }
}
