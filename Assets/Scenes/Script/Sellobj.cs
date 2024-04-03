using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class sellitem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private void OnTriggerEnter(Collider target)
    {

        if (target.gameObject.tag.Equals("canPickUp"))
        {
            Debug.Log("ชน");
            score += 10;
            scoreText.text = "Score : " + score.ToString();
            Destroy(target.gameObject);

        }
    }
}