using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    // Touch offset allows object not to shake when it starts moving
    float deltaX, deltaY;

    Rigidbody2D rb;

    // Object movement not allowed if you touches not the ball at the first time
    bool moveAllowed;

    MovementBadBullet botella;

    // Use this for initialization
    void Start() {

        rb = GetComponent<Rigidbody2D>();
        botella = FindObjectOfType<MovementBadBullet>();

		
	}
	
	// Update is called once per frame
	void Update () {

        // Initiating touch event
        // If touch event takes place
        if (Input.touchCount > 0)
        {

            // Get touch to take a deal with
            Touch touch = Input.GetTouch(0);

            // Obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            // Processing touch phases
            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if(GetComponent<Collider2D> () == Physics2D.OverlapPoint(touchPos))
                    {

                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        moveAllowed = true;

                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;

                        botella.isAtrapado = true;

                        GetComponent<Basura>().esReciclable = true;

                        gameObject.layer = 8;
                        
                       
                    }
                    break;

                case TouchPhase.Moved:

                    if(GetComponent<Collider2D> () == Physics2D.OverlapPoint (touchPos) && moveAllowed)
                    {
                        rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));

                    }
                    break;

                case TouchPhase.Ended:

                    moveAllowed = false;
                    rb.freezeRotation = false;
                    rb.gravityScale = 2;
                    GetComponent<CircleCollider2D>().radius = 1;
                    break;

            }

        }
		
	}
}
