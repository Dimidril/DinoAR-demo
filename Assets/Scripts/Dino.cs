using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using maxstAR;

public class Dino : MonoBehaviour
{
    [SerializeField] private Transform _walkPoint;
    [SerializeField] private float _speed = 5f;

    public void StartWalk()
    {
        StartCoroutine(Walk());
    }

    private IEnumerator Walk()
    {
        while (Vector3.Distance(transform.position, _walkPoint.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, _walkPoint.position, _speed * Time.deltaTime);
            yield return null;
        }
    }
}