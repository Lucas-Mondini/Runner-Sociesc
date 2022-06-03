using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFloorTrigger : MonoBehaviour
{
    public CharacterController2D characterScriptRef;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "FloorSample" || other.name == "Floor")
            characterScriptRef.isGrounded = true;
    }
}
