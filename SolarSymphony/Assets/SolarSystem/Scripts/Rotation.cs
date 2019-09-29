using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    // Rotate the object around its local Y axis at 1 degree per second
    transform.Rotate(Vector3.right * Time.deltaTime);

  }

}


public class PlanetEffects : MonoBehaviour
{
    public void BlinkPlanet()
    {

        gameObject.GetComponent<Renderer>().material.SetColor("_EMISSION", new Color(0.0927F, 0.4852F, 0.2416F, 0.42F));
    }
}