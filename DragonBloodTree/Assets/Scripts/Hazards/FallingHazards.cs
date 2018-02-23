using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHazards : MonoBehaviour
{

    // Hazards
    [SerializeField]
    public GameObject[] Drops;
    public float SpawnTimer;

	// Use this for in  itialization
	void Start ()
    {

        Initialize();

	}

    void Initialize()
    {

        

    }
	
	// Update is called once per frame
	void Update ()
    {
	
        if (Input.GetKeyDown(KeyCode.A))
        {

            GameObject Hazard;
            Hazard = Instantiate(Resources.Load("Prefabs/TestFallingHazard")) as GameObject;
            Hazard.name = "Projectile";

        }

	}



}
