using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamecontroller : MonoBehaviour
{
    //�������ύX�_
    public TextMeshProUGUI scoreLabel;
    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("items").Length;
        scoreLabel.text = count.ToString();
    }
}
