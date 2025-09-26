using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintResultToNext : MonoBehaviour
{
    public void OnNextButton()
    {
        // Battleシーン未実装なら暫定でTitleに戻す等
        SceneManager.LoadScene("TitleScene");
    }
}