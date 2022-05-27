using UnityEngine;

public class Hover : MonoBehaviour, IMovement
{
    public void Move(float[] input, Rigidbody tankBody)
    {
        tankBody.AddForce(new Vector3(0, input[1] * 10, 0));
    }
}
