using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10.0f;
    public ScoreManager scoreManager; //references the scoreManager script so it can be used here
    private Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
          scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
          balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector3.down * Time.deltaTime, 0);

     //destroys balloon after it passes -10 on y axis
     if(transform.position.y < lowerBound)
     {
         scoreManager.DecreaseScoreText(balloon.scoreToGive);
         Destroy(gameObject);
     }
    }
}
