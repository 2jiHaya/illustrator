using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToSelect : MonoBehaviour
{
    // ボタンからInspectorで呼び出す
    public void OnStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }
}