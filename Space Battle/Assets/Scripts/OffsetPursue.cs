using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursue : SteeringBehaviour {
    private void Start() {
        offset = transform.position - leader.transform.position;
        offset = Quaternion.Inverse(leader.transform.rotation) * offset;
    }

    public override Vector3 Calculate() {
        Vector3 worldTarget = (leader.transform.rotation * offset) + leader.transform.position;
        float distance = Vector3.Distance(transform.position, worldTarget);
        float time = distance / boid.maxSpeed;
        Vector3 targetPosition = worldTarget + (leader.velocity * time);
        return boid.ArriveForce(targetPosition);
    }

    public Boid leader = null;
    private Vector3 offset = Vector3.zero;
}