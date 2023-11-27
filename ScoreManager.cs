using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //SImple method used to keep count of score
    public void Score()
    {
        scoreCount = scoreCount + 50;

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }
}
