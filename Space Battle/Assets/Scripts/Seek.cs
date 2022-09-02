using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehaviour {
    private void Start() { }

    private void Update() {
        if (targetGameObject != null) {
            target = targetGameObject.transform.position;
        }
    }

    public override Vector3 Calculate() {
        return boid.SeekForce(target);
    }

    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;
}