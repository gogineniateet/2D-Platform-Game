using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    Score score;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        score = GameObject.Find("ScoreManager").GetComponent<Score>();
        score.ScoreUpdate(10);

    }



}
