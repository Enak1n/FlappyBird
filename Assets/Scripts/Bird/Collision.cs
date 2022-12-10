using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Bird))]
public class Collision : MonoBehaviour
{
    private Bird _bird;
    private AudioSource _point;

    private void Start()
    {
        _point = GetComponent<AudioSource>();
        _bird = GetComponent<Bird>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
        {
            _point.Play();
            _bird.IncreaseScore();
        }
        else
        {
            _bird.Die();
        }
    }

}
