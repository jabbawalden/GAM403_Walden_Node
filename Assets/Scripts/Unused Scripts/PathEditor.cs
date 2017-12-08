using System.Collections.Generic;
using UnityEngine;


public class PathEditor : MonoBehaviour
{


    public enum PathTypes //types of movement paths
    {
        linear,
        loop
    }

    public PathTypes PathType; //change type of path
    public int movementDirection = 1; //1 = clockwise/ -1 = counter clockwise
    public int movingTo = 0; //used to identify point in PathSequence we are moving to
    public Transform[] PathSequence; //[] is for arrays (holds multiple objects) - Array of points in path
   
    //will draw lines between points in Unity for us to see and alter within editor
    //our moving object will follow tis path
    public void OnDrawGizmos()
    {
        //ensures that sequence has points
        //ensures that there are at least two points to constitute a path
        if (PathSequence == null || PathSequence.Length < 2)
        {
            return; //exits OnDrawGizmos if no line is needed
        }

        //for is moving through sequence, i = 1, and if it is less than the pathsequence.length
        //++ adds on to prior number (is an increment)        
        for (var i=1; i < PathSequence.Length; i++)
        {
            //Draw a line between the points
            Gizmos.DrawLine(PathSequence[i - 1].position, PathSequence[i].position);
        }

        if (PathType == PathTypes.loop)
        {
            //Draw line from last point to first point in sequence
            Gizmos.DrawLine(PathSequence[0].position, PathSequence[PathSequence.Length - 1].position);
        }
    }

    //Returns transform component of next point in path
    //FollowPath script will move object to next point




    public IEnumerator<Transform> GetNextPathPoint()
    {
        //ensures that sequence has points (at least 2 points) to create path
        if (PathSequence == null || PathSequence.Length < 1)
        {
            yield break; //exits coroutine 
        }
        //break terminates closest enclosing loop or switches. Control 
        //is passed to the statement that follows (if any)

        while (true) //Usually an infinite loop - but is not because of yield return
        {
            yield return PathSequence[movingTo];

            if (PathSequence.Length == 1)
            {
                continue;
            }

            if (PathType == PathTypes.linear)
            {
                //if the point we move to is less than or equal to zero
                if (movingTo <= 0)
                {
                    movementDirection = 1; //Movement Direction = 1(positive)
                    //thus, movingTo + 1 = 1, then 2, then 3.
                }

                //if movingTo is greater than or equal to PathSequence.Length -1 (so if length is 4,
                //as the value starts at zero, we will be at 4 - 1, which means point 3.) movementDirection = 1.
                //so movingTo (values at 3) + negative 1 (so -1) = 2, then 1, then zero.
                else if (movingTo >= PathSequence.Length - 1)
                {
                    movementDirection = -1; //Negative moves back
                }
                //this loop will then start again, going into the positive direction
            }

            movingTo = movingTo + movementDirection;
            //movementDirection should always be 1 or -1
            //Add value of movementDirection to the index to move us to next point in sequence
            //movingTo identifies what our next point will be
            //movingTo + movementDirection means that it now takes the movementDirection into account
            //(so whether it's positive or negative, that determines which way it goes in the PathSequence)
            //below, we have set some conditions if pathType is loop
            //if loop and moving in positive direction, next point will be the first one again
            //if loop and moving backwards, next point once eaching the start, will be the end point again

            if (PathType == PathTypes.loop)
            {
                //if movingTo is greater than or equal to length (so at the
                //end of the sequence length) movingTo then equals 0 again, so
                //we move to the start point form the last point
                if (movingTo >= PathSequence.Length)
                {
                    //set next point as the first point in sequence
                    movingTo = 0;
                }
                //works the same as above but if we are moving in negative direction
             
                if (movingTo < 0)
                {
                    //Sets the last point in sequence as the next point to move to
                    movingTo = PathSequence.Length - 1; //which equals to a value of 3
                    //thus takes us back to the last point, to move backwards again to first
                    //point, ETC.
                }

            }

        }
    }







}

