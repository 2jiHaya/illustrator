using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectToPaint : MonoBehaviour
{
    public void OnSelectButton()
    {
        SceneManager.LoadScene("PaintScene");
    }
}