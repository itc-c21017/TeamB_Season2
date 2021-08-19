using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Result : MonoBehaviour
{
    float a;
    int score;
    public Text ResultText;
    public Text Achievement;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;

        if ( a >= 7)
        {
            SceneManager.LoadScene("Title");
        }

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
