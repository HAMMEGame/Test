using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //horizontal input is a variable that unity autochecks for you and determines whether you move left or right
        float horizontalInput = Input.GetAxis("Horizontal");
                                        //move on the x-axis by horizontal input by the speed (set in Unity) times real time
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime); 
    }
}
