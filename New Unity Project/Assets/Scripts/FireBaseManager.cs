using System.Collections;
using System.Collections.Generic;
using Firebase;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;

public class FireBaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    DatabaseReference reference;
    public GameObject ranquin;
    public GameObject puntuacio;

    public GameObject boto;
    public bool botobool=false;

    public InputField noms;

    public List<string> llista = new List<string>();
    public string resultatamostraralranquing="";
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        InitcialitzarDB();
    }

    // Update is called once per frame
    void Update()
    {
        ranquin.GetComponent<UnityEngine.UI.Text>().text = resultatamostraralranquing;
        if (botobool == true){
            boto.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }
    void InitcialitzarDB(){
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
        var dependencyStatus = task.Result;
        if (dependencyStatus == Firebase.DependencyStatus.Available) {
            // Create and hold a reference to your FirebaseApp,
            // where app is a Firebase.FirebaseApp property of your application class.
            //app = Firebase.FirebaseApp.DefaultInstance;

            // Set a flag here to indicate whether Firebase is ready to use by your app.
        } else {
            UnityEngine.Debug.LogError(System.String.Format(
            "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
            // Firebase Unity SDK is not safe to use here.
        }
        });
    }
    public void BtnGuardar(InputField noms){
        botobool = true;
        writeNewUser(noms.text,puntuacio.GetComponent<UnityEngine.UI.Text>().text);
        
    }
    private void writeNewUser(string username, string score) {
        User user = new User(int.Parse(score),username);
        string json = JsonUtility.ToJson(user);
        string uniqueid = Random.Range(1,9999999999999999999).ToString()+Random.Range(1,9999999999999999999).ToString();
        reference.Child("Ranking").Child(uniqueid).SetRawJsonValueAsync(json);
        
    }
    public void retrivedata(){
        FirebaseDatabase.DefaultInstance
      .GetReference("Ranking")
      .OrderByChild("score")
      .GetValueAsync().ContinueWith(task => {
        if (task.IsFaulted) {
            Debug.Log("Error");
            Debug.Log("ADEU");
          // Handle the error...
        }
        else if (task.IsCompleted) {
          DataSnapshot snapshot = task.Result;
            foreach (DataSnapshot child in snapshot.Children){
                llista.Add(child.Child("score").Value.ToString()+"\t"+child.Child("name").Value.ToString());
            }
            llista.Reverse();
            int contador= 0;
            foreach (string stri in llista){
                if (contador <= 10){
                    resultatamostraralranquing = resultatamostraralranquing+ "\n" + stri;
                    Debug.Log(resultatamostraralranquing);
                    contador = contador+1;
                }
                else{
                    break;
                }
            }
            
            
          // Do something with snapshot...
        }
      });
    }
    
    

}
public class User {
        public string name;
        public int score;

        public User() {
        }

        public User(int score,string name) {
            this.score = score;
            this.name = name;
        }
}