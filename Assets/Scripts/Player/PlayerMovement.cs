using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 6f;
    [SerializeField]
    private float diagonalMovementMultiplier = 0.75f;
    private float currentMovementSpeed;


    private void Move() {
        transform.position += (new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * currentMovementSpeed) * Time.deltaTime;
    }

    private void Update() {
        if(Mathf.Abs(Input.GetAxis("Horizontal")) >= 0.5f && Mathf.Abs(Input.GetAxis("Vertical")) >= 0.5f) {
            currentMovementSpeed = movementSpeed * diagonalMovementMultiplier;
        } else {
            currentMovementSpeed = movementSpeed;
        }

        Move();
    }
}
