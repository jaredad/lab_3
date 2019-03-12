using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldKey : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public Text objectiveText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Destroy(key);
        Destroy(door);
        objectiveText.text = "You found gold key! Find the silver key to escape!";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            Destroy(key);
            Destroy(door);
            objectiveText.text = "You found gold key! Find the silver key to escape!";
        }
    }
}
