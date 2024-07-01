using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float _ballSpeed = 3f;

    private CircleCollider2D _ballCollider;
    private Rigidbody2D _ballRigidbody;

    private void Awake()
    {
        _ballCollider = GetComponent<CircleCollider2D>();
        _ballRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _ballRigidbody.velocity = Vector3.down * _ballSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Walls"))
        { 
            _ballRigidbody.velocity = -_ballRigidbody.velocity;
        }
        if(collision.gameObject.CompareTag("Bat"))
        {
            float randXHit = UnityEngine.Random.Range(-1f, 1f);
            _ballRigidbody.velocity = new Vector2(randXHit * 5,-_ballRigidbody.velocity.y * 1.5f);
        }
    }
}
