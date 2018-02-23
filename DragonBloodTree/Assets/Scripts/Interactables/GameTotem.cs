using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTotem : MonoBehaviour
{

    public int NextLevel;
    public int OrbRequirement;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		

	}

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (other.gameObject.GetComponent<SimplePlayer>().CurrentOrbs == OrbRequirement)
                {

                    // Do Stuff
                    SceneManager.LoadScene(NextLevel);

                }

            }

        }

    }

}
