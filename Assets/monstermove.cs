using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class monstermove : MonoBehaviour
{
    // Start is called before the first frame update
    //public string targetGOName;
    public float speed = 4;

    Rigidbody2D rigdBody;

    public GameObject goTarget;

    // Start is called before the first frame update
    void Start()
    {
        //targetObject = GameObject.Find("Player");

        rigdBody = GetComponent<Rigidbody2D>();
        rigdBody.gravityScale = 1;
        rigdBody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (goTarget.transform.position - this.transform.position).normalized;

        float vx = dir.x * speed;
        float vy = dir.y * speed;

        rigdBody.velocity = new Vector2(vx, vy);

        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);

        if (collision.gameObject.name == goTarget.name)
        {
            GameObject _goTarget = GameObject.Find(collision.gameObject.name);
            if (_goTarget != null)
            {
                _goTarget.SetActive(false);
            }

        }

    }
}
