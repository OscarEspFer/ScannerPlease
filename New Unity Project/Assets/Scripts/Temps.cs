using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Temps : MonoBehaviour
{
    // Start is called before the first frame update
    private string scene;
    public int vides = 0;
    public int benfets = 0;
    public static int score;
    public static float temps=60;
    public string nextlvl;

    public string menu;
    public string ranking;
    
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
        StartCoroutine(esperador());
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] dividit = scene.Split('-');
        if (int.Parse(dividit[0])+1 != 12){
            if (vides == 3){
                SceneManager.LoadScene(menu);
                
                
            }
        }
        else{
            if (vides == 3){
                score = benfets;
                Data.Save();
                SceneManager.LoadScene(ranking);
                
            }
        }
    }
    IEnumerator esperador(){
        yield return new WaitForSecondsRealtime(temps);
        string[] dividit = scene.Split('-');
        if (int.Parse(dividit[0])+1 != 12){
            if (benfets >= 10){
                if (EnableLvls.nivell < int.Parse(dividit[0])+1 && int.Parse(dividit[0])+1 != 11){
                    EnableLvls.nivell = int.Parse(dividit[0])+1;
                    Data.Save();
                }
                if (int.Parse(dividit[0])+1 == 11){
                    StartGame.infinit = 1;
                    Data.Save();
                }
                
                SceneManager.LoadScene(nextlvl);
            }
            else{
                vides = 3;
            }
        }
        else{

        }
    }

}
