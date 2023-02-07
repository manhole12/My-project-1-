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
    void LateUpdate()// 계속 시행한다(여러 가지 처리의 마지막에)
    {
        Vector3 pos = this.transform.position; // 자신의 위치
        pos.z = -10; // 카메라이므로 앞으로 이동시킨다 
        Camera.main.gameObject.transform.position = pos;
    }
}
