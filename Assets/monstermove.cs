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
    public int hp = 3;
    [SerializeField]
    public int range = 2;

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
        float dest_x = goTarget.transform.position.x - this.transform.position.x;
        float dest_y = goTarget.transform.position.y - this.transform.position.y;

        if (dest_x * dest_x + dest_y * dest_y <= range * range)
        {
            Vector3 dir = (goTarget.transform.position - this.transform.position).normalized;

            float vx = dir.x * speed;
            float vy = dir.y * speed;

            rigdBody.velocity = new Vector2(vx, vy);

            this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
        }
        else
        {
            float vx = 1 * speed;

            if (this.GetComponent<SpriteRenderer>().flipX)
            {
                vx = -1 * speed;
            }

            rigdBody.velocity = new Vector2(vx, 0);
        }

        if (hp == 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().flipX = !this.GetComponent<SpriteRenderer>().flipX;

        if (collision.gameObject.name == goTarget.name)
        {
            GameObject _goTarget = GameObject.Find(collision.gameObject.name);
            if (_goTarget != null)
            {
                _goTarget.SetActive(false);
                Time.timeScale = 0;
                worldmanager.isover = true;
            }

        }
        if (collision.gameObject.CompareTag("boom"))
        {
            hp--;
        }
    }
}
