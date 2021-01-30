using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private int someVariable = 100;
    // Start is called before the first frame update
    void Start()
    {
        int someVariable = 1000;
        Debug.Log("Hello, world!");
        Debug.Log(this.someVariable);
        Debug.Log(someVariable);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
