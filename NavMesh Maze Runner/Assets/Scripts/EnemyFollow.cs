using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    public static int lives = 3;
    public Text livesText;
    

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "lives " + lives;
        enemy.SetDestination(player.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ( "Player"))
        {
            other.gameObject.SetActive(false);
            lives -= 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (lives <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER!!!");
        }
    }
}
