using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    GameObject Orb;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    float rotateSpeed = 20f;
    private void Start()
    {
        
    }

    private void Update()
    {
        Orb.transform.RotateAround(Player.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }
}
