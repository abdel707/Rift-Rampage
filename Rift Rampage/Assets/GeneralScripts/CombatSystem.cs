using System;
using Unity.VisualScripting;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    private PlayerMovement movement;
    private void Start()
    {
        PlayerMovement movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        movement.AddRecoil(Vector3.back * 500f);
    }

}
