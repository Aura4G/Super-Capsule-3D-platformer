using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBullet : MonoBehaviour
{
    float Lifetime = 0f;
    [SerializeField] float MaxLife = 10f;

    // Update is called once per frame
    void Update()
    {
        Lifetime += Time.deltaTime;

        if (Lifetime >= MaxLife)
        {
            Destroy(gameObject);
        }
    }
}
