using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // health require
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    private Vector2 targetPos; //main target position on the center of the camera
    public float Yincrement; //set int into 5 for increasing the character up ang down

    public float speed;  //movement
    public float maxHeight; 
    public float minHeight;

    public int health = 3;

    public GameObject effect;//particle of the character
    public Animator camAmin;//camera shake
    public Text HealthDiplay; // health will be display

    public GameObject gameOver;

    private void Update()
    {
        HealthDiplay.text = health.ToString();

        if (health <= 0)
        {

            gameOver.SetActive(true);
            Destroy(gameObject);
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            //Shake the camera
            //camAmin.SetTrigger("shake");
            //particles for character
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //transform.position = targetPos;
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            //Shake the camera
            //camAmin.SetTrigger("shake");
            //particles for character
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }
    }
}
