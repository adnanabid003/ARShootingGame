using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SpawnControl.i++;
        SpawnControl.Instance.SpawnPointManage(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
