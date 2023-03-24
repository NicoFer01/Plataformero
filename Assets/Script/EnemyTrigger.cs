using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().Death();
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            float yOffSet = 0.5f;

            if (transform.position.y + yOffSet < collision.transform.position.y)
            {
                collision.gameObject.GetComponent<PlayerController>().PlayerPoints();
                Destroy(gameObject);
            }

            else
            {
                collision.gameObject.GetComponent<PlayerController>().Death();
            }
        }
    }
}
