using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnControl : MonoBehaviour
{
    public static SpawnControl Instance;
    public List<GameObject> SpawnObjects;
    public List<GameObject> SpawnOzomb;
    public GameObject prefab_, ShootButton;
    public float Spawntimer=0;
    public static bool Isplace;
    public GameObject[] zomblist;
    public static int i;
    public Text spawntimershow;
    public GameObject Timerobj;
    private void Awake()
    {
        Instance = this;
        SpawnObjects = new List<GameObject>();
    }
    public void SpawnPointManage(GameObject obj)
    {

        if (Spawntimer > 0)
        {
            SpawnObjects.Add(obj);
            ////Spawn Zombie
            GameObject go = Instantiate(prefab_, obj.transform.position, obj.transform.rotation);
            SpawnOzomb.Add(go);
            go.SetActive(false);
            go.GetComponent<Zomb_Ai>().enabled = false;
        }
       
    }
   
    public void ZombieBanJao()
    {
        int vaar = Random.Range(0, SpawnObjects.Count);
        GameObject go = Instantiate(prefab_, SpawnObjects[vaar].transform.position, SpawnObjects[vaar].transform.rotation);
        go.SetActive(true);

    }
    void Start()
    {
        Isplace = true;
    }
    //public void OnGenZomb()
    //{
    //   // SpawnObjects.Add(obj);
    //    ////Spawn Zombie
    //    GameObject go = Instantiate(prefab_, obj.transform.position, obj.transform.rotation);
    //    //go.SetActive(true);
    //}

    // Update is called once per frame
    void Update()
    {
        if (Spawntimer <= 0f)
        {
            Isplace = false;
            Timerobj.SetActive(false);
            Game_Script.IsTimer = true;
            foreach (GameObject fakeobj in SpawnOzomb)
            {
                fakeobj.SetActive(true);
                fakeobj.GetComponent<Zomb_Ai>().enabled = true;
            }
        }
        else
        {
          
            Spawntimer -= 1 * Time.deltaTime;
            spawntimershow.text = Spawntimer.ToString();
        }
        //if (SpawnObjects.Count == 3)
        //{
        //    ShootButton.SetActive(true);
        //}
        if (Spawntimer <= 0)
        {
            ShootButton.SetActive(true);
        }
    }
}
