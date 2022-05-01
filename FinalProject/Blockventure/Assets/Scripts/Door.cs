using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int sceneToLoad;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.key == 1)
        {
            Debug.Log("You opened the door");
            Destroy(gameObject);
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.Log("Door is locked.");
        }
    }
}
