using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key pressed");
        }

        if(Input.GetKey(KeyCode.Backspace))
        {
            Debug.Log("Backspace key held");
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H key up");
        }
    }
}
