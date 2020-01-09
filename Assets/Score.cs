using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private GameObject scoreText;
    int score = 0; //スコア計算用変数

    void Start()
    {
        score = 0;
        this.scoreText = GameObject.Find("scoreText");
       
    }

    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallCloudTag")
        {
            score += 10;
        }
        if (yourTag == "SmallStarTag")
        {
            score += 15;
        }
        if (yourTag == "LargeCloudTag")
        {
            score += 20;
        }
        else
        {
            score += 25;
        }
        this.scoreText.GetComponent<Text>().text = "Score:"+this.score.ToString();
    }
    

    void Update()
    {
        

    }
}
