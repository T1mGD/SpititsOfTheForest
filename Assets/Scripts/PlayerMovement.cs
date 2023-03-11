using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    private Rigidbody2D _rigidbody;
    private Vector2 _input;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _input.x = Input.GetAxis(StringConsts.Input.Horizontal);
        _input.y = Input.GetAxis(StringConsts.Input.Vertical);
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _input.normalized * _speed * Time.fixedDeltaTime);
    }
}
