using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyChangeMat : MonoBehaviour
{
    // Start is called before the first frame update
    //renderer calls and assigns the rend
    //public static in this case would localize and allow other scripts to call and synch which ability is active
    Renderer rend;
    public static float abilityNum;


    void Start()
    {
        //assings the material and ability at start
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        settings.startColor = new ParticleSystem.MinMaxGradient(Color.white);
        abilityNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        checkKeyPress();
    }


    //checkKeyPress checks which and assigns a color to the particle system so if 1 is pressed then white is applied 2 pressed green is applied
    //i'd recommend setting up an array and assigning the different colors or particle systems to it and cycling through with a count system to allow the use of buttons to cycle
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
