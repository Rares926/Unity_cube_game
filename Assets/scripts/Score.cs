using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

   public Transform player;
    public Text score;

    void Update()
    {
     
        score.text = (player.position.z+133).ToString("0");
        if (((player.position.z + 133) > 80) && ((player.position.z + 133) < 100))
            score.text = "Keep Going";
                 if (((player.position.z + 133) > 150) && ((player.position.z + 133) < 170))
            score.text = "Almost there";
    }
}
