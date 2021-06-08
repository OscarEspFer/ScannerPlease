using System.Collections;
using System.Collections.Generic;
using Firebase;
using UnityEngine;
using Firebase.Database;

public class FireBaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puntuatge;
    DatabaseReference reference;
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        InitcialitzarDB();
    }

    // Update is called once per frame
    void Update()
    {
        
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
    public void BtnGuardar(){
        writeNewUser("Vero","12");
    }
    private void writeNewUser(string username, string score) {
        User user = new User(score);
        string json = JsonUtility.ToJson(user);

        reference.Child("Ranking").Child(username).SetRawJsonValueAsync(json);
    }
    public void retrivedata(){
        FirebaseDatabase.DefaultInstance
      .GetReference("Ranking")
      .GetValueAsync().ContinueWith(task => {
        if (task.IsFaulted) {
            Debug.Log("Error");
            Debug.Log("ADEU");
          // Handle the error...
        }
        else if (task.IsCompleted) {
          DataSnapshot snapshot = task.Result;
            Debug.Log(snapshot.Value.ToString());
            Debug.Log("HOLA");
          
            string str = snapshot.Child("Oscar").Child("score").Value.ToString();
            Temps.score = int.Parse(str);

            List<string> llista = new List<string>();

            Debug.Log(snapshot.GetType().Name);
            foreach (DataSnapshot child in snapshot.Children){
                Debug.Log(child.Child("score").Value.ToString());
                llista.Add(child.Child("score").Value.ToString());
            }
            llista.Sort();
            llista.Reverse();
            foreach (string stri in llista){
                Debug.Log(stri);
            }
          // Do something with snapshot...
        }
      });
    }
    

}
public class User {
        public string score;

        public User() {
        }

        public User(string score) {
            this.score = score;
        }
}