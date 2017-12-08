using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public enum MovementType
    {
        MoveTowards,
        LerpTowards

    }

    public MovementType Type = MovementType.MoveTowards;
    public PathEditor MyPath;
    public float Speed = 1;
    public float MaxDistanceToGoal = .1f; //how close it needs to be to the point to be
    //considered at the point

    private IEnumerator<Transform> pointInPath;
    //references points returned from MyPath.GetNextPathPoint

    public void Start()
    {
        //Start is going to get the object moving initially

        if (MyPath == null)
        {
            return;
        }

        //referencing the coroutine GetNextPathPoint
        pointInPath = MyPath.GetNextPathPoint();
        //Accesses next point in path to move to
        //MoveNext method advances the enumerator to the next element of the
        //collection (namespace is in System.Collections)
        pointInPath.MoveNext();

        //Makes sure there is a point ot move to
        if (pointInPath.Current == null)
        {
            return;
        }

        //sets the position of object to our starting point (point zero)
        transform.position = pointInPath.Current.position;
    }

    //updates each frame
    public void Update()
    {
        //Checks if there is a path otherwise we exit from update
        if (pointInPath == null || pointInPath.Current == null)
        {
            return;
        }

        //if type is equal to MoveTowards
        if (Type == MovementType.MoveTowards)
        {
            //move to next point in path using MoveTowards
            transform.position =
                Vector3.MoveTowards(transform.position,
                pointInPath.Current.position, Time.deltaTime * Speed);

        }
        else if (Type == MovementType.LerpTowards)
        {
            //move to next point using lerp
            transform.position = Vector3.Lerp(transform.position,
                pointInPath.Current.position, Time.deltaTime * Speed);
        }
        //Time.deltaTime to provide smooth visuals (moves per second rather than per
        //frame, so that the speed of object that player sees is dependant on their framerate,
        //which would be problematic as framerates can vary.

        //Uses math stuff that I don't really understand (Pythagorean Theorem)
        //Basically checks to see if we are close enough to next point before we move to following one

        var distanceSquared = (transform.position - pointInPath.Current.position).sqrMagnitude;
        if (distanceSquared < MaxDistanceToGoal * MaxDistanceToGoal)
        {
            pointInPath.MoveNext();
        }

        //Script credit to YouContributeGames on youtube (with my own additional notes in attempt to better
        //understand the code)
    }




}
