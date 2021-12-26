using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{

    public void toggle(string scene){
        SceneManager.LoadScene(scene);
    }
}
