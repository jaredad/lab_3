using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    Light t_light;
    public GameObject lamp;
    public float minTime = 0.1f;
    public float maxTime = 0.5f;
    public Material material1;
    public Material material2;
    // Start is called before the first frame update
    void Start()
    {
        t_light = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            lamp.GetComponent<Renderer>().enabled = !lamp.GetComponent<Renderer>().enabled;
            t_light.enabled = !t_light.enabled;
        }
    }
}
