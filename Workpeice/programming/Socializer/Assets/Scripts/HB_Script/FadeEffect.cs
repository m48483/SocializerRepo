using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    public Image image;
    float time = 0.0f;
    float F_time = 1.5f;
    SceneChange _sceneChange;
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(0.1f);
    private WaitForSecondsRealtime _UIDelay2 = new WaitForSecondsRealtime(0.3f);

    public void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
    }
    public void fadeEffect()
    {
        _sceneChange.FadeOut();
    }
    public IEnumerator FadeOut()
    {
        image.gameObject.SetActive(true);
        Color color = image.color;

        while (color.a < 1f)
        {
            time += Time.deltaTime / F_time;
            color.a = Mathf.Lerp(0, 1, time);
            image.color = color;
            yield return null;
        }
        time = 0f;
        yield return new WaitForSeconds(1f);
    }
    public IEnumerator FadeIn()
    {
        Color color = image.color;

        while (color.a > 0f)
        {
            time += Time.deltaTime / F_time;
            color.a = Mathf.Lerp(1, 0, time);
            image.color = color;
            yield return null;
        }
        image.gameObject.SetActive(false);
        yield return null;
    }
}
