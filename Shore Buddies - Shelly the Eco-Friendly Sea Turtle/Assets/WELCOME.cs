
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class WELCOME : MonoBehaviour
{
    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showText()
    {
        text.SetActive(!text.activeSelf);
    }
}
