using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursue : SteeringBehaviour {
    public Boid leader;
    Vector3 offset;

    void Start() {
        offset = transform.position - leader.transform.position;
        offset = Quaternion.Inverse(leader.transform.rotation) * offset;
    }

    public override Vector3 Calculate() {
        Vector3 worldTarget = leader.transform.TransformPoint(offset); 
        float dist = Vector3.Distance(transform.position, worldTarget);
        float time = dist / boid.maxSpeed;
        Vector3 targetPos = worldTarget + (leader.velocity * time);
        return boid.ArriveForce(targetPos);
    }
}