using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class StartGame : MonoBehaviour
{

    InputAction attackAction;
    public void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");

    }
    public void Update()
    {
        if (attackAction.WasPressedThisFrame()) { SceneManager.LoadScene("Fight_Scene"); }
    }
}
