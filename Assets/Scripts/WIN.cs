using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour

{
    public AudioSource AS;
    public AudioClip goal;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.name == "First Person Player")
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("VictoryScreen");

        }
    }
}
    
