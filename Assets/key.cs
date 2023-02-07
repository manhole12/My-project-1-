using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class key : MonoBehaviour
{
    public GameObject Key;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == Key.name)
        {
            GameObject _Key = GameObject.Find(collision.gameObject.name);
            if (_Key != null)
            {
                counter.value += 1;
                Destroy(this.gameObject);
            }

        }
    }
}
