using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dragon_Behaviour : MonoBehaviour
{
    public bool dragonTurn = false;
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
        if (heroBehavior.player_Turn == false && dragonTurn)
        {
            attack = UnityEngine.Random.Range(0, 1);
            if (attack == 0 || attack == 1)
            {
                StartCoroutine(FireAttack());
            }
            else if (attack == 1)
            {
                StartCoroutine(SwipeAttack());

            }
            //testturn = true;
            gameObject.GetComponent<Renderer>().material = idle;
        }
    }

    private IEnumerator FireAttack()
    {
        Debug.Log("vuur");
        gameObject.GetComponent<Renderer>().material = fire;
        yield return new WaitForSeconds(1f);
    }
    private IEnumerator SwipeAttack()
    {

        Debug.Log("Swipe");
        gameObject.GetComponent<Renderer>().material = sweep_1;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<Renderer>().material = sweep_2;
        yield return new WaitForSeconds(1f);

    }
}
