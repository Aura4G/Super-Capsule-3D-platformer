using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectile;
    float metronome = 0f;
    int seconds = 0;
    bool beenShot;
    [SerializeField] public float coef = 1f;
    [SerializeField] public float launchVelocity = 100f;

    void Start()
    {
        beenShot = false;
    }

    // Update is called once per frame
    void Update()
    {
        metronome += Time.deltaTime;
        seconds = System.Convert.ToInt32(metronome);
        if (seconds % coef == 0)
        {
            if (!beenShot)
            {
                Shoot();
            }
        }
        else
        {
            beenShot = false;
        }
    }

    void Shoot()
    {
        GameObject EnemyPellet = Instantiate(projectile, transform.position, transform.rotation);
        EnemyPellet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
        beenShot = true;
    }
}
