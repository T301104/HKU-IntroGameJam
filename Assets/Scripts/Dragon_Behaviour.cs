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
    [SerializeField] AudioClip fireAttack;
    [SerializeField] AudioClip sweepAttack;
    AudioSource audioSource;
    [SerializeField] Material idle;
    [SerializeField] Material sweep_1;
    [SerializeField] Material sweep_2;
    [SerializeField] Material fire;
    int attack = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

        if (dragon_hp <= 0)
        {
            SceneManager.LoadScene("GameWin");
        }
        if (heroBehavior.player_Turn == false && dragonTurn)
            {
                attack = UnityEngine.Random.Range(0, 2);
            if (attack == 0)
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
            }
    }

    private IEnumerator FireAttack()
    {
        gameObject.GetComponent<Renderer>().material = fire;
        audioSource.PlayOneShot(fireAttack);
        yield return new WaitForSeconds(1f);
        heroBehavior.player_Turn = true;
        gameObject.GetComponent<Renderer>().material = idle;

    }
    private IEnumerator SwipeAttack()
    {

        gameObject.GetComponent<Renderer>().material = sweep_1;
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = sweep_2;
        audioSource.PlayOneShot(sweepAttack);
        yield return new WaitForSeconds(0.5f);
        heroBehavior.player_Turn = true;
        gameObject.GetComponent<Renderer>().material = idle;

    }
}
