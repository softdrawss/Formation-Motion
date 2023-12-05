using UnityEngine;
 
using Pada1.BBCore;
using Pada1.BBCore.Framework; 

[Condition("MyConditions/Is Robber Near?")]
[Help("Checks whether CoRobber is near the Treasure.")]
public class IsRobberNear : ConditionBase
{
    public override bool Check()
    {
        GameObject robber = GameObject.Find("Robber");
        GameObject treasure = GameObject.Find("Treasure");
        return Vector3.Distance(robber.transform.position, treasure.transform.position) < 10f;
    }
} 
