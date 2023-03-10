using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Tagetcam : MonoBehaviour
{
   public List<Transform> targets;
   public Vector3 offset;
   private Vector3 velocity;
   public float smoothtime = 0.5f;
   public float minZoom = 40f;
   public float maxZoom = 10f;
   public float zoomlimiter = 50f;
   private Camera cam;

   void Start()
   {
    cam = GetComponent<Camera>();
   }

   void LateUpdate()
   {
    if(targets.Count == 0)
    {
        return;
    }
    move();
    zoom();
   
   }

void move()
{
     Vector3 centerPoint = GetCenterpoint();
    Vector3 newPosition = centerPoint + offset;
    transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothtime );
}

float GetGreatestDistance()
{
    var bounds = new Bounds(targets[0].position, Vector3 . zero);
    for (int i = 0; i < targets.Count; i++)
    {
        bounds.Encapsulate(targets[i].position);
    }
    return bounds.size.x;
}

void zoom()
{
   float newZoom = Mathf.Lerp(maxZoom,minZoom,GetGreatestDistance() / zoomlimiter );
   cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
}

   Vector3 GetCenterpoint()
   {
    if (targets.Count == 1)
    {
       return targets[0].position;
    }

    var bounds = new Bounds(targets[0].position, Vector3.zero);
    for (int i = 0; i < targets.Count; i++)
    {
        bounds.Encapsulate(targets[i].position);
    }
    return bounds.center;
   }
}
