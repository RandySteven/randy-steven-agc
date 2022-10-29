using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField]
    private int speed;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SquareMove(speed);
    }

    private void SquareMove(int speed){
        transform.position += SquareMovement() * Time.deltaTime * speed;
    }

    private Vector3 SquareMovement(){
        Vector3 movement = Vector3.zero;
        if(Input.GetAxisRaw("Horizontal") != 0){
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        }
        if(Input.GetAxisRaw("Vertical") != 0){
            movement = new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
        }
        return movement;
    }

}
