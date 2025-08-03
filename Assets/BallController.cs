using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるｚ軸の最小値
    private float visiblePosZ = -6.5f;
    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    public ScoreController scoreController;


    // Start is called before the first frame update 
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //ゲームオーバーのテキストを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    // 衝突したオブジェクトのタグを確認し、スコアを加算する
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            this.scoreController.Score += 10;
        }
        if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            this.scoreController.Score += 20;
        }
        if (collision.gameObject.CompareTag("SmallCloudTag"))
        {
            this.scoreController.Score += 50;
        }
        if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            this.scoreController.Score += 100;
        }
    }
}
    

