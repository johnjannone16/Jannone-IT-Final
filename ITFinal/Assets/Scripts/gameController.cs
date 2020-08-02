using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float maxMana = 100;
    public float currentMana;
    public float manaRecharge;

    public manaAmountInd manaAmount;
    public healthAmountInd healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Insert) && currentHealth > 0)
        {
            TakeDamage(20);
        }

        if(currentHealth == 0)
        {
            SceneManager.LoadScene("TestLevel");
        }

        if(killTrigger.inKillTrigger == true)
        {
            currentHealth = 0;
        }

        if (airDash.manaCost == true)
        {
            useManaDash(20);
        }

        if(TriggerAnimatorScript.manaUse == true)
        {
            useManaPush(0.5f);
        }

        if (currentMana < 100 && fireflyChangeMat.abilityNum == 4)
        {
            regainMana(manaRecharge);

        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }

        void useManaDash(float mana)
        {

            currentMana -= mana;
            manaAmount.SetMana(currentMana);
        }

        void useManaPush(float mana)
        {
            currentMana -= mana;
            manaAmount.SetMana(currentMana);
        }

        void regainMana(float mana)
        {
            currentMana += mana;
            manaAmount.SetMana(currentMana);
        }

        

    }
}