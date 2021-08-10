using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int score;
    public Text ResultText;
    public Text Achievement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = UI.GetScore();

        Achievement.text = "Level of achievement@" + score + "“";

        if ( score >= 20)
        {
            ResultText.text = "RANK SSS";
        }
        else if( score >= 10)
        {
            ResultText.text = "RANK A";
        }
        else
        {
            ResultText.text = "RANK C";
        }
    }

    
}
