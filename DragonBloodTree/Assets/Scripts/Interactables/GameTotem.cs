using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTotem : MonoBehaviour
{

    // Next Level (Scene Number) to load when Orbs is collected
    public int NextLevel;
    //
    private int OrbRequirement;

	// Use this for initialization
	void Start ()
    {

        Initialize();

	}

    void Initialize()
    {

        GetOrbCount();

    }
	
	// Update is called once per frame
	void Update ()
    {
		

	}

    private void GetOrbCount()
    {

        // Gets Total Number of Orbs in Level
        GameObject[] Check;
        Check = GameObject.FindGameObjectsWithTag("Collectibles");

        for (int i = 0; i < Check.Length; i++)
        {

            if (Check[i].gameObject.name == "Orb")
            {

                OrbRequirement++;

            }

        }

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
