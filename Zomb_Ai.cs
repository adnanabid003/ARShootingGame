using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zomb_Ai : MonoBehaviour
{
    //public GameObject Player;
    public float Dis;
    GameObject Player;
    public  float Health;
    public  bool IsDead = false;
    public static int HitValue;
    private Animator Anim;
    int trig = 0;
    //public float AwaitTime=0f;
    // Start is called before the first frame update
    void Start()
    {
        Game_Script.IsAttack = 2;
        Anim = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player");
        if (UiManager.GunIndex == 1)
        {
            HitValue = 10;
        }
        if (UiManager.GunIndex == 2)
        {
            HitValue = 20;
        }
        if (UiManager.GunIndex == 3)
        {
            HitValue = 30;
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

    // Update is called once per frame
    void Update()
    {
        if (UiManager.currentlevel == 2)
        {
            transform.LookAt(Player.transform.position);
            Dis = Vector3.Distance(gameObject.transform.position, Player.transform.position);
            if (Dis > 0.7)
            {
                Anim.SetBool("Run", true);
                transform.Translate(Vector3.forward * 0.5f * Time.deltaTime);
            }
            else if (Dis <= 0.7 && IsDead == false)
            {
                Anim.SetBool("Run", false);
                Anim.SetBool("Attack", true);
                Game_Script.IsAttack = 1;
                // print("Attack");

            }
        }

        if (IsDead == true)
        {

            //Anim.SetBool("Run", false);
            //Anim.SetBool("Attack", false);
            //Anim.SetBool("Death", true);
            gameObject.SetActive(false);
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            Game_Script.IsAttack = 2;
            if (trig == 0)
            {
                Game_Script.Zombiekill++;
                print("Zombie kill : " + Game_Script.Zombiekill);
                // Game_Script.trig = 0;
                trig = 1;
            }
            //   gameObject.GetComponent<Animation>().Play("die");

        }

    }
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Bullet")
        {
            print("Hit");
            Health -= 10;
            Destroy(hit.gameObject);
            if (Health < 10)
            {

                IsDead = true;
                //  Destroy(gameObject,2f);
            }
        }
    }
}
