using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroBehavior : MonoBehaviour
{

    [SerializeField] Dragon_Behaviour dragon_Behaviour;

    [SerializeField] AudioSource audioSource;

    InputAction attackAction;
    [SerializeField] AudioClip hit01;
    [SerializeField] AudioClip hit02;
    [SerializeField] AudioClip hit03;
    [SerializeField] AudioClip hit04;
    [SerializeField] AudioClip hit05;
    [SerializeField] AudioClip hit06;
    [SerializeField] AudioClip hit07;
    [SerializeField] AudioClip hit08;
    [SerializeField] AudioClip hit09;
    [SerializeField] AudioClip hit10;

    [SerializeField] public float hero_HP = 3;

    [SerializeField] Material idle;
    [SerializeField] Material attack;

    public bool player_Turn = true;
    [SerializeField] bool soundPlay = false;
    private float space_Presses = 0;
    [SerializeField] private float attackDuration = 1.2f;
    float attackMultiplyer = 0.5f;
    float attackStrenght = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.WasPressedThisFrame())
        {
            space_Presses++;
            if (soundPlay)
            switch (space_Presses)
            {
                case 0:
                    break;
                case 2:
                    audioSource.PlayOneShot(hit01);
                    break;
                case 4:
                    audioSource.PlayOneShot(hit02);
                    break;
                case 6:
                    audioSource.PlayOneShot(hit03);
                    break;
                case 8:
                    audioSource.PlayOneShot(hit04);
                    break;
                case 10:
                    audioSource.PlayOneShot(hit05);
                    break;
                case 12:
                    audioSource.PlayOneShot(hit06);
                    break;
                case 14:
                    audioSource.PlayOneShot(hit07);
                    break;
                case 16:
                    audioSource.PlayOneShot(hit08);
                    break;
                case 18:
                    audioSource.PlayOneShot(hit09);
                    break;
                case 20:
                    audioSource.PlayOneShot(hit10);
                    break;
            }
        }

        if (player_Turn && attackAction.WasPressedThisFrame())
        { 
            player_Turn = false;
            soundPlay = true;
            StartCoroutine(PlayerAttack(attackDuration));
        }
    }

    private IEnumerator PlayerAttack(float attackDuration)
    {
        space_Presses = 0;
        yield return new WaitForSeconds(attackDuration);
        if (space_Presses > 10)
        {
            space_Presses = 10;
        }
        attackStrenght = space_Presses * attackMultiplyer;
        Debug.Log(attackStrenght);
        dragon_Behaviour.dragon_hp = dragon_Behaviour.dragon_hp - attackStrenght;
        soundPlay = false;
        dragon_Behaviour.dragonTurn = true;
    }
}
