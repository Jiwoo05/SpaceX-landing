using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    public int a = 1;
    public int b = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(b.ToString());
        if (Input.GetKey(KeyCode.Space))
        { 
            a = a + b;
            transform.position = new Vector3(a, 0, 0);
        }
        else
        {
            transform.position = new Vector3(a, 0, 0);
        }
    }
}
