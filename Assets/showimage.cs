using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showimage : MonoBehaviour
{
    public int Count = 0;

    // Update is called once per frame
    void Update()
    {
        if (Count > 10)
        {
            GetComponent<Image>().enabled = false;
        }
        else
        {
            GetComponent<Image>().enabled = true;
        }
    }
}
