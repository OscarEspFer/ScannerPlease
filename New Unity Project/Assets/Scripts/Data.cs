using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // Start is called before the first frame update
    public static void Save(){
        PlayerPrefs.SetInt("nivell", EnableLvls.nivell);
        PlayerPrefs.SetInt("benfets", Temps.score);
        PlayerPrefs.SetInt("infinit", StartGame.infinit);
        PlayerPrefs.Save();
    }
    public static void Load(){
        EnableLvls.nivell = PlayerPrefs.GetInt("nivell",0);
        StartGame.infinit = PlayerPrefs.GetInt("infinit",0);
        Temps.score = PlayerPrefs.GetInt("benfets");
    }
}
