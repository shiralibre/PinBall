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
            score += 5;
        }
        if (yourTag == "SmallStarTag")
        {
            score += 10;
        }
        if (yourTag == "LargeCloudTag")
        {
            score += 15;
        }
        if (yourTag=="LargeStarTag")
        {
            score += 20;
        }
        this.scoreText.GetComponent<Text>().text = "Score:"+this.score.ToString();
    }
    

    void Update()
    {
        

    }
}
