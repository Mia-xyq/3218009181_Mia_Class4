using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Vector2 ThisVec;
    Rigidbody2D rigidbody2;
    public GameObject EndImg;
	// Use this for initialization
	void Start () {
        ThisVec = transform.position;
        rigidbody2 = this.transform.GetComponent<Rigidbody2D>();
        InitThis();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void InitThis()
    {
        transform.position = ThisVec;
        rigidbody2.velocity = 6 * Vector2.down;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "1")
        {
            collision.gameObject.GetComponent<Block>().BlockHp -= 1;
           // Destroy()

        }
        if (collision.gameObject.tag == "2")
        {
            EndImg.SetActive(true);
            Time.timeScale = 0;
            // Destroy()

        }
    }
}
