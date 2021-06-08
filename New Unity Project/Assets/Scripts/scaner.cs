using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaner : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject scanerResult;
    public void OnButtonPress(){
        StartCoroutine(esperador());
    }
    IEnumerator esperador(){
        animator.SetBool("Apretat", true);
        yield return new WaitForSecondsRealtime(1);
        scanerResult.gameObject.SetActive(true);
        animator.SetBool("Apretat", false);
    }
}
