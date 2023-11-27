using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Text : MonoBehaviour
{
    public GameObject ingredients;
    public GameObject method;
    // Start is called before the first frame update
    void Start()
    {
        ingredients = GetComponent<GameObject>();
        method = GetComponent<GameObject>();
        ingredients.SetActive(true);
        method.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonIsPressed()
    {
        ingredients.SetActive(false);
        method.SetActive(true);
    }
}
