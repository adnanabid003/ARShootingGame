using GoogleARCoreInternal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_Script : MonoBehaviour
{
    //private Transform[] Inst_point;
    public GameObject Zombie;
    public GameObject Bullet;
    public Transform Pinstpoint;
    public static int trig = 0;
    public static int IsAttack;
    public int Phealth = 100;
    public float TimeAwait = 0;
    public Image Demage;
    public GameObject[] GunsObject;
    public float Timer_;
    public Text Timer_show;
    public static int Zombiekill;
    public Text Zombiekillshow;
    public int Highscore;
    public Text Highscoreshow;
    public GameObject GameOverPanel;
    public static bool IsTimer;
    void Start()
    {
        ARCoreAndroidLifecycleManager checkobj = new ARCoreAndroidLifecycleManager();
        checkobj._Initialize();

        trig = 0;
        IsAttack = 0;
        Zombiekill = 0;
        Time.timeScale = 1;
        GunsObject[UiManager.GunIndex].SetActive(true);
        Highscore = PlayerPrefs.GetInt("highscore", Highscore);
        Highscoreshow.text = Highscore.ToString();
        print("Highscore :" + Highscore);
        GameOverPanel.SetActive(false);
    }


    void Update()
    {
        Zombiekillshow.text = Zombiekill.ToString();
        if (Zombiekill > Highscore)
        {
            Highscore = Zombiekill;
            PlayerPrefs.SetInt("highscore", Highscore);
            Highscoreshow.text = Highscore.ToString();
            print("Highscore :" + Highscore);
        }
        if (IsTimer == true)
        {
            Timer_ += 1 * Time.deltaTime;
            Timer_show.text = Timer_.ToString();
        }

        if (Timer_ > 60)
        {
            //  print("GameOver");
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        //if (IsAttack == 1)
        //{
        //    if (TimeAwait > 2f)
        //    {
        //        if (Phealth > 0)
        //        {
        //            Phealth -= 10;
        //            Demage.fillAmount -= 0.1f;
        //            print("E Attack" + Phealth);
        //            // Time.timeScale = 0;
        //        }
        //        else
        //        {
        //            Time.timeScale = 0;
        //            GameOverPanel.SetActive(true);
        //        }

        //        TimeAwait = 0f;
        //    }
        //    else
        //    {
        //        TimeAwait += 1 * Time.deltaTime;
        //    }

        //}
        //GameObject[] Inst_objects = GameObject.FindGameObjectsWithTag("Point");
        //if (Inst_objects.Length>0 && trig == 0) 
        //{

        //    for (int x = 0; x < Inst_objects.Length; x++)
        //    {
        //        //Inst_point[x] = Inst_objects[x].transform;
        //        Instantiate(Zombie, Inst_objects[x].transform.position, Inst_objects[x].transform.rotation);
        //    }
        //    trig = 1;
        //}

    }

    public void OnBullet()
    {
        Instantiate(Bullet, Pinstpoint.position, Pinstpoint.rotation);
    }
    public void OnHome()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }
    public void OnRestart()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }
}
