using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float limitSec = 3; // 초 수 : Inspector에 지정

    void Start()
    { // 처음에 시행한다
        Destroy(this.gameObject, limitSec); // 지정 초 후에 소멸하는 예약 
    }
    void Update()
    {

    }
}
