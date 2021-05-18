using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


    public void LoadNextLevel(int sceneNum)
    {
        StartCoroutine(LoadLevel(sceneNum));
    }

	// Tässä voi tehdä mahdollisesti fade efektin jos tahtoo.
    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("StartFade");

        yield return new WaitForSecondsRealtime(transitionTime);
        Time.timeScale = 1f;

        SceneManager.LoadScene(LevelIndex);
    }

    public void LevelReset()
    {
        StartCoroutine(ResetLevel());
    }

    IEnumerator ResetLevel()
    {
        transition.SetTrigger("StartFade");

        yield return new WaitForSecondsRealtime(transitionTime);
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
