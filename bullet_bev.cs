using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_bev : MonoBehaviour
{
    public static float Bullet_Range;
    // Start is called before the first frame update
    void Start()
    {
        if (UiManager.GunIndex == 0)
        {
            Bullet_Range = 2f;
        }
        if (UiManager.GunIndex == 1)
        {
            Bullet_Range = 3f;
        }
        if (UiManager.GunIndex == 2)
        {
            Bullet_Range = 4f;
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
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        Destroy(gameObject, Bullet_Range);
    }
}
