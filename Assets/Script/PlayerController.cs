using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float jumpPower = 6.5f;
    [SerializeField] private Text Points;
    [SerializeField] private StateMachine _State;
    private Rigidbody2D rb2d;
    private bool grounded;
    private bool jump;
    private int enemyPoints = 0;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.position += Vector3.right * Input.GetAxis("Horizontal") * _speed * Time.fixedDeltaTime;
        }

        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "Water") Death();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle") grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle") grounded = false;
    }

    public void Death()
    {
        Destroy(this.gameObject);
        _State.STATE_MACHINE = "GameOver";
    }

    public void PlayerPoints()
    {
        enemyPoints += 100;
        Points.text = "Points " + enemyPoints;
    }
}
