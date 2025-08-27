using System.Collections;
using UnityEngine;

public class HeroBehavior : MonoBehaviour
{

    [SerializeField] public float hero_HP = 3;
    public bool player_Turn = true;
    private float space_Presses = 0;
    private float attackDuration = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            space_Presses++;
        }

        if (player_Turn && Input.GetKeyDown("space"))
        {
            StartCoroutine(PlayerAttack(attackDuration));
        }
    }

    private IEnumerator PlayerAttack(float attackDuration)
    {
        yield return new WaitForSeconds(attackDuration);
    }
}
