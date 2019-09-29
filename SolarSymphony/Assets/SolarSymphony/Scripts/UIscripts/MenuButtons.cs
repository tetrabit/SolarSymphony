using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public Animator animator;

    private float _time = 0f;
    private float _transitionTime = 1f;
    private string _sceneToSwitch;
    private bool _switchScene;

    public void PlayGame()
    {
        animator.SetTrigger("fade_out");
        _sceneToSwitch = "SolarSymphony";
        _switchScene = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        animator.SetTrigger("fade_out");

        Application.Quit();
    }

    public void CreditsLoad()
    {
        animator.SetTrigger("fade_out");
        _sceneToSwitch = "CreditScreen";
        _switchScene = true;
    }

    private void FixedUpdate()
    {
        if(_switchScene)
        {
            _time += Time.deltaTime;
            if (_time > _transitionTime)
                TransitionScene(_sceneToSwitch);
        }

    }

    private void TransitionScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    ///Test function
    public void TestGame()
    {
        Debug.Log("Test!");
    }
}
