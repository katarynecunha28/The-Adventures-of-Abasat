using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    public float speed;
    private SpriteRenderer sr;
    public bool infloor = true;

    public int coins;

    public float minHeight = -10f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    // Update is called once per frame
    void Update()
    {
        Jump();
        CheckFall();
    }

    void MovePlayer()
    {
        float horizontalMoviment = Input.GetAxisRaw("Horizontal");
        //transform.position += new Vector3(horizontalMoviment * Time.deltaTime * speed,0,0);
        rbPlayer.velocity = new Vector2(horizontalMoviment * 2, rbPlayer.velocity.y);

        if (horizontalMoviment > 0)
        {
           sr.flipX = false;
        }
        else if (horizontalMoviment < 0)
        {
           sr.flipX = true;
        }
    }

    void Jump()
    {
    if(Input.GetButtonDown("Jump") && infloor)
        {
           rbPlayer.AddForce(new Vector2(0,5), ForceMode2D.Impulse);
           infloor = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name == "Ground")
       {
          infloor = true;
       }
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
       
      if(collision.gameObject.tag == "Coins")
      {
          Destroy(collision.gameObject);
          coins = coins + 1;
      }
      else if(collision.gameObject.tag == "VictoryCoin")
      {
          Destroy(collision.gameObject);
          SceneManager.LoadScene("Victory");
          
      }
       
    }
    void CheckFall()
    {
        if (transform.position.y < minHeight)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
