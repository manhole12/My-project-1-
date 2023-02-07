using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public static int value;
    public int outValue;
    public int startCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        value = startCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
