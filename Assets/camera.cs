using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()// ��� �����Ѵ�(���� ���� ó���� ��������)
    {
        Vector3 pos = this.transform.position; // �ڽ��� ��ġ
        pos.z = -10; // ī�޶��̹Ƿ� ������ �̵���Ų�� 
        Camera.main.gameObject.transform.position = pos;
    }
}
