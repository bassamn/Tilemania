using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
