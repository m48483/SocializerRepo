using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingScene : MonoBehaviour
{
    public static string nextScene;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }



    IEnumerator LoadScene()
    {

        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;

        float timer = 0.0f;
        float Delay_t = 3.0f;
        while (!op.isDone)
        {
            yield return null;

            timer += Time.deltaTime;
            if (timer >= Delay_t){
                op.allowSceneActivation = true;
                yield break;
            }
        }
    }
}