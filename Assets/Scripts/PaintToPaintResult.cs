using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintToPaintResult : MonoBehaviour
{
    public float paintTime = 10f; // 塗り時間（秒）
    private float timer = 0f;
    private bool isPainting = false;

    // 塗り開始ボタンから呼び出す
    public void OnStartPainting()
    {
        isPainting = true;
        timer = 0f;
    }

    void Update()
    {
        if (isPainting)
        {
            timer += Time.deltaTime;
            if (timer >= paintTime)
            {
                isPainting = false;
                SceneManager.LoadScene("PaintResultScene");
            }
        }
    }
}