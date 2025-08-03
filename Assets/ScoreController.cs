using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // スコアを保持する変数
    private int score = 0;

    // スコアのプロパティ
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    // スコアを表示するUIテキストとの紐づけ
    public UnityEngine.UI.Text scoreText;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     scoreText.text = "Score: " + score;   
    }
}
