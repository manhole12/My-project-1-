using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float limitSec = 2; // 초 수 : Inspector에 지정
    void Start()
    { // 처음에 시행한다
        Destroy(this.gameObject, limitSec); // 지정 초 후에 소멸하는 예약 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!(collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("boom")))
        {
            playermanager.boomCounter -= 1;
            Destroy(this.gameObject);
        }
    }
}
