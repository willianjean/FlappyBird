using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
    public string destiny;
    public Vector3 destinyPosition;
    // Use this for initialization
    private void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            //other.transform.position = destinyPosition;
            SceneManager.LoadScene(destiny);
            other.transform.position = destinyPosition;
            
        }

    }
}
