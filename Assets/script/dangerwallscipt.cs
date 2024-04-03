using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dangerwallscipt : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
