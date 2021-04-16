using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public ThirdPersonCharacter character;

    public int health;

    public Text scoreText;
    public int count = 0;
    public Text winText;

    void Start()
    {
        cam = Camera.main;
        agent.updateRotation = false;


    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }

     

        }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Prize")
        {
            other.gameObject.SetActive(false);
            count += 10;
            scoreText.text = "Score: " + count;
        }
      

            if (count >= 40)
            {
                winText.gameObject.SetActive(true);
            }


        }


    }
