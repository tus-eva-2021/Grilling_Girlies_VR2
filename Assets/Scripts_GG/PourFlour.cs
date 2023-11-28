using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourFlour : MonoBehaviour
{
    public ParticleSystem flour;
    // Start is called before the first frame update
    void Start()
    {
      //  flour.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Bowl"))
        {
             // flour.SetActive(true);
            flour.Play();
        }
        else
        {
            flour.Stop();
            flour.Clear();
        }
    }
    private void OnTriggerExit(Collider other)
    {
     flour.Stop();
        flour.Clear();

    }
}
