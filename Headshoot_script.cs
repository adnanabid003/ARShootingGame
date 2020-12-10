using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headshoot_script : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
		//if()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Bullet")
        {
            if (UiManager.currentlevel == 3)
            {
                print("Hit");

                gameObject.GetComponent<Zomb_Ai>().Health -= 0;
                Destroy(hit.gameObject);
                if (gameObject.GetComponent<Zomb_Ai>().Health < 10)
                {

                    gameObject.GetComponent<Zomb_Ai>().IsDead = true;
                    //  Destroy(gameObject,2f);
                }
            }
            
        }
    }
}
