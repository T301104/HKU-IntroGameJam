using System;
using UnityEngine;

public class Dragon_Behaviour : MonoBehaviour
{
    [SerializeField] public float dragon_hp = 100;
    [SerializeField] HeroBehavior heroBehavior;
    [SerializeField] Material idle;
    [SerializeField] Material sweep_1;
    [SerializeField] Material sweep_2;
    [SerializeField] Material fire;
    [SerializeField] bool testturn = false;
    Material currentmaterial;
    int attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = 0;
        currentmaterial = gameObject.GetComponent<Material>();
    }

    float timer = 0;
    bool timerReached = false;
    
    // Update is called once per frame
    void Update()
    {
        if (testturn == false)
        {
            attack = UnityEngine.Random.Range(0, 1);
            if (attack == 0 )
            {
                currentmaterial = sweep_1;
            }
            else if (attack == 1)
            {
            
            }
            testturn = true;
            currentmaterial = idle;
        }
        // stage transition
        if (dragon_hp < 50)
        {

        }
    }
}
