#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Debug.Log("We're quitting the game!");
            #if UNITY_EDITOR
                EditorApplication.isPlaying = false; // Stop play mode in editor
            #else
                Application.Quit(); // Quit the application if built
            #endif
        }
    }
}
