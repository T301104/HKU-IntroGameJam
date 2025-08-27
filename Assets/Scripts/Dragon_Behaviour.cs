using UnityEngine;

public class Dragon_Behaviour : MonoBehaviour
{
    [SerializeField] public float dragon_hp = 100;
    [SerializeField] HeroBehavior heroBehavior;
    int attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = 0;
    }


    
    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            attack = Random.Range(0, 1);
            if (attack == 0)
            {

            }
            else if (attack == 1)
            {
            
            }
                
        }
    }
}
