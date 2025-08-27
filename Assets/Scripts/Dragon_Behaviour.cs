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
    int attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = 0;
    }

    
    // Update is called once per frame
    void Update()
    {
        timer = 0;
        if (testturn == false)
            {
            attack = UnityEngine.Random.Range(0, 1);
            if (attack == 0 || attack == 1)
            {
                Debug.Log("vuur");
                gameObject.GetComponent<Renderer>().material = fire;
            }
            else if (attack == 1)
            {
                Debug.Log("Swipe");
                gameObject.GetComponent<Renderer>().material = sweep_1;
                gameObject.GetComponent<Renderer>().material = sweep_2;
            }
                //testturn = true;
                gameObject.GetComponent<Renderer>().material = idle;
        }
    }
}
