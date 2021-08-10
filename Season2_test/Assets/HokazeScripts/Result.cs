using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int score;
    public Text ResultText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = UI.GetScore();
            

        if ( score >= 2)
        {
            ResultText.text = "RANK SSS";
        }
        else
        {
            ResultText.text = "RANK C";
        }
    }

    
}
