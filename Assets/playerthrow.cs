using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerthrow : MonoBehaviour
{
    public GameObject newPrefab; // ����� ������ ��Inspector�� ����
    public int maxCount = 20; // �� ��Inspector�� ����

    public float throwX = 7;  // ������ �� ��Inspector�� ����
    public float throwY = 5;  // ������ ����Inspector�� ����
    public float offsetY = 3;

    bool pushFlag = false;
    bool leftFlag = false;

    void Update()
    {
        if (Input.GetKey("right"))// ���� ������ Ű�� ������
        {
            leftFlag = false;
        }
        if (Input.GetKey("left"))// ���� ���� Ű�� ������
        {
            leftFlag = true;
        }
        if (Input.GetKey("up"))// ���� �� Ű�� ������
        {
            if (pushFlag == false)// ������ ���� ������
            {
                pushFlag = true;
                Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                Vector3 newPos = this.transform.position;
                newPos.y += offsetY;
                // �������� �����
                GameObject newGameObject = Instantiate(newPrefab) as GameObject;
                newPos.z = -5; // �տ� ǥ���Ѵ�
                newGameObject.transform.position = newPos;

                Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();
                if (leftFlag)// ���� �����̸� �ݴ� �������� ������
                {
                    rbody.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
                }
                else// ������ �����̸� ������ �������� ������ 
                {
                    rbody.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
                }
            }
        }
        else
        {
            pushFlag = false;
        }
    }
}
