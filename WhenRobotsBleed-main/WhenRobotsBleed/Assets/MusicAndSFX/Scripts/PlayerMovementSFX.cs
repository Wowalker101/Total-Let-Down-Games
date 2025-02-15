using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSFX : MonoBehaviour
{
    PlayerController pc;
    WeponShoot weaponShoot;
    PlayerAtack playerAttack;
    AudioSource asource;


    public AudioClip DashClip;
    public AudioClip JumpClip;
    public AudioClip BlasterClip;
    public AudioClip AttackClip;
   

    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerController>();
        weaponShoot = GetComponent<WeponShoot>();
        playerAttack = GetComponent<PlayerAtack>();
        asource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.isGrounded == true && pc.rb.velocity.magnitude > 2f && asource.isPlaying == false)
        {

        }

        if (pc.isGrounded && asource.isPlaying == false)

        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                asource.Play();

            asource.volume = Random.Range(0.5f, 0.8f);
            asource.pitch = Random.Range(0.8f, 1.1f);
        }

        if (pc.hasDash == true && Input.GetKeyDown(KeyCode.Z))
        {
            asource.PlayOneShot(DashClip, 0.5f);
        }

        if (Input.GetButtonDown("Jump"))
        {
            asource.PlayOneShot(JumpClip, 0.8f);
        }

        if (weaponShoot.hasGun && Input.GetKeyDown(KeyCode.X))
        {
            asource.PlayOneShot(BlasterClip, 0.8f);
        }


        if (playerAttack.hasSword && Input.GetKeyDown(KeyCode.C))
        {
            asource.PlayOneShot(AttackClip, 0.8f);
        }
    }
}
