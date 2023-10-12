using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ufo : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    private int count = 0;
    public Text score_1;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
	private void OnTriggerEnter2D(Collider2D obiekt)
	{
		if (obiekt.gameObject.CompareTag("pickup"))
        {
			count++;
			Destroy(obiekt.gameObject);



        }
    }




}
