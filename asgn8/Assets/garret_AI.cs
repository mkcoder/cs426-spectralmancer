using UnityEngine;
using System.Collections;

public class garret_AI : MonoBehaviour {
    public GameObject player_object;
    private GameObject bot;
    private Material material;
    private float moveSpeed;   
        
    void Start() {
        bot = gameObject;

        material = bot.GetComponent<Renderer>().material;
        
        moveSpeed = 10;
    }
    
    void Update() {
        transform.position = Vector3.MoveTowards
            (transform.position, player_object.transform.position, Time.deltaTime * moveSpeed);
        finiteStateMachine(bot);
    }

    void finiteStateMachine(GameObject bot)
    {
        int distance;
        distance = (int)Vector3.Distance(transform.position, player_object.transform.position);
                
        if (distance > 0 && distance < 50) {
            material.color = Color.green;
            moveSpeed = 5;
        }
        else if (distance > 49 && distance < 100) {
            material.color = Color.yellow;
            moveSpeed = 15;
        }
        else if (distance > 99 && distance < 150) {
            material.color = Color.red;
            moveSpeed = 30;
        }
        else if (distance > 149 && distance < 200) {
            material.color = Color.cyan;
            moveSpeed = 20;
        }
        else {
            material.color = Color.blue;
            moveSpeed = 0;
        }
    }
}
