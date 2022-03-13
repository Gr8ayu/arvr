using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject loading_panel;
    public Slider slider;
    public Text txt;

    public void Load_Scene(string scene_name)
    {
        StartCoroutine(Load_Async_Scene(scene_name));
        loading_panel.SetActive(true);
    }



    IEnumerator Load_Async_Scene(string scene_name)
    {
        AsyncOperation operation= SceneManager.LoadSceneAsync(scene_name);
        while(operation.isDone==false)
        {
            float process = Mathf.Clamp01(operation.progress/0.9f);
            slider.value=process;
            txt.text=(process*100).ToString() +"%";


            yield return null;
        }
    }
  
}
