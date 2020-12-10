using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject[] Panels;
    public AudioSource GameMusic;
    public GameObject MusicOn, MusicOff, normalg, highg, SoundOn, SoundOff;
    public static int GunIndex, IsSound;
    public static int currentlevel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBack()
    {
        Panels[0].SetActive(true);
        Panels[1].SetActive(false);
        Panels[2].SetActive(false);
        Panels[3].SetActive(false);
    }

    public void OnPlay()
    {
        Panels[0].SetActive(false);
        Panels[1].SetActive(true);
        Panels[2].SetActive(false);
        Panels[3].SetActive(false);
    }

    public void OnLevel1()
    {
        currentlevel = 1;
        Application.LoadLevel(1);
    }
    public void OnLevel2()
    {
        currentlevel = 2;
        Application.LoadLevel(1);
    }
    public void OnLevel3()
    {
        currentlevel = 3;
        Application.LoadLevel(1);
    }
    public void OnGunSelection()
    {
        Panels[0].SetActive(false);
        Panels[1].SetActive(false);
        Panels[2].SetActive(true);
        Panels[3].SetActive(false);
    }
    public void OnOption()
    {
        Panels[0].SetActive(false);
        Panels[1].SetActive(false);
        Panels[2].SetActive(false);
        Panels[3].SetActive(true);
    }
    public void OnQuit()
    {
        Application.Quit();
    }
    public void OnMusicOn()
    {
        GameMusic.volume = 1;
        MusicOff.SetActive(true);
        MusicOn.SetActive(false);
    }
    public void OnMusicOff()
    {
        GameMusic.volume = 0;
        MusicOff.SetActive(false);
        MusicOn.SetActive(true);
    }
    public void OnSoundOn()
    {
        IsSound = 1;
        SoundOff.SetActive(true);
        SoundOn.SetActive(false);
    }
    public void OnSoundOff()
    {
        IsSound = 2;
        SoundOff.SetActive(false);
        SoundOn.SetActive(true);
    }

    public void OnHighg()
    {

        QualitySettings.currentLevel = QualityLevel.Fantastic;
        normalg.SetActive(true);
        highg.SetActive(false);
    }

    public void OnNormalg()
    {
        QualitySettings.currentLevel = QualityLevel.Fast;
        normalg.SetActive(false);
        highg.SetActive(true);
    }

    public void OnGun(int index)
    {
        //Zomb_Ai.HitValue=index
        GunIndex = index;
        print(index);
    }

}
