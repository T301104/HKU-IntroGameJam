using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Dragon_Behaviour : MonoBehaviour
{
    public bool dragonTurn = false;
    [SerializeField] public float dragon_hp = 45;
    [SerializeField] HeroBehavior heroBehavior;
    [SerializeField] Material idle;
    [SerializeField] Material sweep_1;
    [SerializeField] Material sweep_2;
    [SerializeField] Material fire;
    int attack = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (dragon_hp <= 0)
        {
        SceneManager.LoadScene("GameWin", LoadSceneMode.Additive);
        }
        if (heroBehavior.player_Turn == false && dragonTurn)
            {
                attack = UnityEngine.Random.Range(0, 1);
            if (attack == 0 || attack == 1)
            {
                dragonTurn = false;
                StartCoroutine(FireAttack());
                
            }
            else if (attack == 1)
            {
                dragonTurn = false;
                StartCoroutine(SwipeAttack());

            }
                //testturn = true;
                gameObject.GetComponent<Renderer>().material = idle;
            }
    }

    private IEnumerator FireAttack()
    {
        gameObject.GetComponent<Renderer>().material = fire;
        yield return new WaitForSeconds(1f);
        heroBehavior.player_Turn = true;
    }
    private IEnumerator SwipeAttack()
    {

        gameObject.GetComponent<Renderer>().material = sweep_1;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<Renderer>().material = sweep_2;
        yield return new WaitForSeconds(1f);
        heroBehavior.player_Turn = true;

    }
}
