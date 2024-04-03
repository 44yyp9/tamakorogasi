using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamecontroller : MonoBehaviour
{
    //Ç±Ç±Ç™ïœçXì_
    public TextMeshProUGUI scoreLabel;
    public GameObject winnerLabelObject;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("items").Length;
        scoreLabel.text = count.ToString();
        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
        }
    }
}
