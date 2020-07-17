using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    static void Update()
    {
        //supposed to stop time but doesn't seem to work. Maybe it only stops animations?
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }
    }
}
