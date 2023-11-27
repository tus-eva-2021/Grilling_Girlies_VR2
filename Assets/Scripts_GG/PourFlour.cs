using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourFlour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<ParticleSystem>().Stop();
      
    }
}
