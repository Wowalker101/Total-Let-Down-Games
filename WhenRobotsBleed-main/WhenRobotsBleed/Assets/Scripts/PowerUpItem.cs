using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    private bool isActive = true;
    public bool swordGrant = false;
    public bool gunGrant = false;
    public bool dashGrant = false;
    public AudioClip powerUpSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActive && collision.gameObject.GetComponent<PlayerController>())
        {
            if (dashGrant) collision.gameObject.GetComponent<PlayerController>().hasDash = true;
            if (powerUpSound != null) AudioSource.PlayClipAtPoint(powerUpSound, gameObject.transform.position, 1.85f);
            Destroy(gameObject);
        }

        if (isActive && collision.gameObject.GetComponent<WeponShoot>())
        {
            if (gunGrant) collision.gameObject.GetComponent<WeponShoot>().hasGun = true;
            if (powerUpSound != null) AudioSource.PlayClipAtPoint(powerUpSound, gameObject.transform.position, 5.85f);
            Destroy(gameObject);
        }

        if (isActive && collision.gameObject.GetComponent<PlayerAtack>())
        {
            if (swordGrant) collision.gameObject.GetComponent<PlayerAtack>().hasSword = true;
            if (powerUpSound != null) AudioSource.PlayClipAtPoint(powerUpSound, gameObject.transform.position, 5.85f);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {

    }
}
