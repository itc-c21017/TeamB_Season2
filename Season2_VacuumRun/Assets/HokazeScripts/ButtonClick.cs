using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnButtonStartClicked()
    {
        Invoke("Main", 1);
    }
    void Main()
    {
        SceneManager.LoadScene("User guide");
    }
}
