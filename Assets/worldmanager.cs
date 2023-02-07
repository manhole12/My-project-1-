using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldmanager : MonoBehaviour
{
    [SerializeField]
    public GameObject door;
    public static bool finishable = false;
    [SerializeField]
    public GameObject finishUI;
    public static bool isfinish = false;
    [SerializeField]
    public GameObject overUI;
    public static bool isover = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter.value == 4)
        {
            door.GetComponent<SpriteRenderer>().color = Color.black;
            finishable = true;
        }
        if (isfinish)
        {
            finishUI.SetActive(true);
        }
        if (isover)
        {
            overUI.SetActive(true);
        }
    }
}
