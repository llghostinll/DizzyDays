using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trains : MonoBehaviour
{
    public Vector3 dircetion;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dircetion.normalized * speed * Time.deltaTime;


    }
    public void SetDirection(Vector3 newDirection)
    {
        dircetion = newDirection;
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.name == "First Person Player")
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("You Lose");

        }
    }
}
   


