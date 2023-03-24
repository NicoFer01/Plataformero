using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private StateMachine _State;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_State.STATE_MACHINE == "Play") transform.position += Vector3.right * _speed * Time.deltaTime;
    }

    /*private void OnTriggerEnter2D(Collider2D collisionObstacle)
    {
        if (collisionObstacle.tag == "Obstacle")
        {
            _speed *= -1f;
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle") _speed *= -1f;

        if (collision.gameObject.tag == "Water") Destroy(gameObject);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (transform.position.y < collision.transform.position.y) Destroy(gameObject);
        }
    }*/
}
