using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float limitSec = 3; // �� �� : Inspector�� ����

    void Start()
    { // ó���� �����Ѵ�
        Destroy(this.gameObject, limitSec); // ���� �� �Ŀ� �Ҹ��ϴ� ���� 
    }
    void Update()
    {

    }
}
