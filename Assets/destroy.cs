using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float limitSec = 2; // �� �� : Inspector�� ����
    void Start()
    { // ó���� �����Ѵ�
        Destroy(this.gameObject, limitSec); // ���� �� �Ŀ� �Ҹ��ϴ� ���� 
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
