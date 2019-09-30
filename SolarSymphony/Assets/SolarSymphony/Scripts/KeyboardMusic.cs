using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyboardMusic : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.C);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.D);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.E);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.F);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.G);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.A);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.B);
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            SolarSymphony.Instance.AudioController.Play(Sound.BassDrum);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
