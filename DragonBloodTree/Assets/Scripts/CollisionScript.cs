using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    public float Speed;
    private float BaseSpeed;

	// Use this for initialization
	void Start ()
    {

        initialize();

	}

    void initialize()
    {

        BaseSpeed = Speed;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
        if (!Input.anyKeyDown)
        {


            Speed = 0;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Speed = BaseSpeed;
            this.transform.position += Vector3.left * Speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed = BaseSpeed;
            this.transform.position += Vector3.right * Speed * Time.deltaTime;

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Collectibles")
        {

            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Hazards")
        {

            // Damage Character
            // Make Character Invincible

        }

        if (collision.gameObject.tag == "Interactables")
        {

            // Conditions for Interaction


        }

    }





}
