using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyChangeMat : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer rend;
    public static float abilityNum;


    void Start()
    {
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        settings.startColor = new ParticleSystem.MinMaxGradient(Color.white);
        abilityNum = 1;
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
            abilityNum = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.green);
            abilityNum = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.red);
            abilityNum = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
            abilityNum = 4;
        }
    }

}
