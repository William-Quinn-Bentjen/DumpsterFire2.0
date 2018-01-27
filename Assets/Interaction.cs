using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    struct Civillian
    {
       
    }

    bool alive = true;

    struct Zombie
    {

    }

    // Use this for initialization
    void Start ()
    {
        
	}
	
    void onTriggerEnter(Collider Civillian)
    {
        alive = false;

    }

	// Update is called once per frame
	void Update ()
    {
        if (alive == false)
        {
            //AI switched to zombie script
            Civillian = Zombie;
        }
        else
        {
//AI stays with current alive script
            
        }
	}
}
