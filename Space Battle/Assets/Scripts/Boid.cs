using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {
    private void Start() {
        SteeringBehaviour[] behaviours = GetComponents<SteeringBehaviour>();
        foreach (SteeringBehaviour b in behaviours) {
            this.behaviours.Add(b);
        }
    }

    public Vector3 SeekForce(Vector3 target) {
        Vector3 desired = target - transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        return desired - velocity;
    }

    public Vector3 ArriveForce(Vector3 target, float slowingDistance = 10.0f, float deceleration = 3) {
        Vector3 toTarget = target - transform.position;
        float distance = toTarget.magnitude;
        if (distance == 0.0f) { return Vector3.zero; }
        Vector3 desired;
        if (distance < slowingDistance) {
            desired = ((distance / slowingDistance) * maxSpeed) * (toTarget / distance);
        } else {
            desired = maxSpeed * (toTarget / distance);
            deceleration = 1f;
        }
        return (desired - velocity) * deceleration;
    }

    private Vector3 Calculate() {
        force = Vector3.zero;
        foreach (SteeringBehaviour b in behaviours) {
            if (b.isActiveAndEnabled) {
                force += b.Calculate() * b.weight;
                if (force.magnitude > maxForce) {
                    force = Vector3.ClampMagnitude(force, maxForce);
                    break;
                }
            }
        }
        return force;
    }

    private void Update() {
        acceleration = Calculate() / mass;
        velocity += acceleration * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        if (velocity.magnitude > 0) {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 3.0f);
            transform.LookAt(transform.position + velocity, tempUp);
            transform.position += velocity * Time.deltaTime;
            velocity *= (1.0f - (damping * Time.deltaTime));
        }
    }

    private List<SteeringBehaviour> behaviours = new List<SteeringBehaviour>();

    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 velocity = Vector3.zero;

    public float mass = 1;
    [Range(0.0f, 10.0f)] public float damping = 0.01f;
    [Range(0.0f, 1.0f)] public float banking = 0.1f;
    public float maxSpeed = 5.0f;
    public float maxForce = 10.0f;
}
