using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyChangeMat : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer rend;
    
    void Start()
    {
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        settings.startColor = new ParticleSystem.MinMaxGradient(Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        checkKeyPress();
    }

    private void checkKeyPress()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.white);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.red);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.green);
        }
    }

}
