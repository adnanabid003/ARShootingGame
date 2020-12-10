using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_fake : MonoBehaviour
{
    public float Dis;
    public Transform point;
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(point.transform.position);
        Dis = Vector3.Distance(gameObject.transform.position, point.transform.position);
        if (Dis > 1)
        {
            Anim.SetBool("Run", true);
            transform.Translate(Vector3.forward * 1f * Time.deltaTime);
        }
        else if (Dis<= 1)
        {
            Anim.SetBool("Run", false);
            Anim.SetBool("Attack", true);
         }
        if (UiManager.IsSound == 1)
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        else if (UiManager.IsSound == 2)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
    }
}
