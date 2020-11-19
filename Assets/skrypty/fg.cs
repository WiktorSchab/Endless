using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fg : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 2;
    float y = 5.2f;
    void Start()
    {
       
        Debug.Log("dziala" + (int)(x + y));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
