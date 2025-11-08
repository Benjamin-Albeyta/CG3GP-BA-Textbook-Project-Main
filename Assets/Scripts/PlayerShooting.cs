using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    //Allows me to reference other objects here in the code by linking the two of them
    public GameObject prefab;

    public GameObject shootPoint;

    public ParticleSystem muzzleEffect;

    public AudioSource shootSound;

    public int bulletsAmount;
    public int fireRate;
    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void OnFire(InputValue value)
    {
        animator.SetBool("Shooting", value.isPressed);
        if (value.isPressed)
        {
            InvokeRepeating("Shoot", fireRate, fireRate);
        }
        else
        {
            CancelInvoke();
        }
    }

    private void Shoot()
    {
        
        if (bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;

            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            shootSound.Play();
            muzzleEffect.Play();
        }
    }

}
