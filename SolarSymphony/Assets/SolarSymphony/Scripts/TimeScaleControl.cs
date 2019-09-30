using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale += 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale += 0.05f;
        }
        if (Input.GetKeyDown(KeyCode.Y) && Time.timeScale >= .05f)
        {
            Time.timeScale -= 0.05f;
        }

        // Adjust fixed delta time according to timescale
        // The fixed delta time will now be 0.02 frames per real-time second
        // Time.fixedDeltaTime = 0.02f * Time.timeScale;

    }
}
