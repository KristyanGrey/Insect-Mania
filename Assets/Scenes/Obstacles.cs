using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    public GameObject effect;
    private Animator camAnim;


    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            //shake camera
            //camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<playerController>().health -= damage;
            Debug.Log(other.GetComponent<playerController>().health);
            Destroy(gameObject);
        }
    }
}
