using UnityEngine;

public class Belt : MonoBehaviour, IMovement
{
    public void Move(float[] input, Rigidbody tankBody)
    {
        tankBody.AddForce(tankBody.gameObject.transform.forward * (input[1] * 4));
        tankBody.MoveRotation(tankBody.gameObject.transform.rotation * Quaternion.Euler(0, input[0] * 4, 0));
    }
}
