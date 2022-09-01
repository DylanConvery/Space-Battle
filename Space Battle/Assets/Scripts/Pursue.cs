using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : SteeringBehaviour {
    public Boid target;

    public override Vector3 Calculate() {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        float time = distance / boid.maxSpeed;
        Vector3 targetPos = target.transform.position + (target.velocity * time);
        return boid.SeekForce(targetPos);
    }
}