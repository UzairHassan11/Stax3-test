using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    public AudioSource bg;
    public void ToggleSound()
    {
        bg.mute = !bg.mute;
    }

    public void LoadLobby(){
        SceneManager.LoadScene(0);
    }
}
