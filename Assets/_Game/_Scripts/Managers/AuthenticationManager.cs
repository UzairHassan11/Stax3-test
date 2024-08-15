using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthenticationManager : MonoBehaviour {

// bool loaded = false;
// private void Start()
// {
//     if(!loaded) 
//     {
//         Invoke("LoginAnonymously", .25f);
//         loaded = true;
//         print("called");
//     }
// }
	[ContextMenu("Load")]
    public async void LoginAnonymously() {
        
        using (new Load("Logging you in...")) {
            await Authentication.Login();
            SceneManager.LoadSceneAsync("Lobby");
        }
    }
}