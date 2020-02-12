using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public GameObject BulletObject;
    PlayerData data;


	void Start ()
    {
        data = GetComponent<PlayerData>();
	}
	
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            if(data.Ammo >= 1)
            {
                Instantiate(BulletObject, transform.position, Quaternion.identity);
                data.Ammo--;
            }
         
        }
		
	}
}
