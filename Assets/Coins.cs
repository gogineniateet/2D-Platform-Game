using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        score = GameObject.Find("Score").GetComponent<Score>();
       // Score.ScoreUpdate(1);

    }



}
