using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int scoreToGive = 100; //score given for each popped balloon

    public int clickToPop = 3; //number of clicks to pop a balloon

    public float scaleIncrease = 0.1f; //scale increase after each balloon is clicked

    public ScoreManager scoreManager; //references the scoreManager script so it can be used here

    // Start is called before the first frame update
    void Start()
    {
        //reference score mananger
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; //-= short for clickToPop = clickToPop - 1;

        transform.localScale += Vector3.one * scaleIncrease;

        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
