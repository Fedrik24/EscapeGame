using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instace;
    public TextMeshProUGUI text;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instace == null)
        {
            instace = this;
        }
    }

    public void TambahScore(int coinValue)
    {
        score += coinValue;
        text.text = "Item : " + score.ToString();
    }
}
