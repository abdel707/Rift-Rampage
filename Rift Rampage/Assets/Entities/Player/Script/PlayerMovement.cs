using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float BaseSpeed = 5f;

    private float _CurrentSpeed;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _CurrentSpeed = BaseSpeed;
    }

    public float CurrentSpeed { get; private set; }

    public void AddRecoil(Vector3 RecoilDirection)
    {
        rigidBody.AddForce(RecoilDirection, ForceMode.Impulse);
    }



}
