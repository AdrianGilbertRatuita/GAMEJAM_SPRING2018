using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    public IInteractable Object;

	// Use this for initialization
	void Start ()
    {

        Initialize();

	}
	
    void Initialize()
    {

        Object = new TestInteractable();

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                if (Object.Conditions())
                {

                    Object.Execute();

                }

            }

        }

    }

}
