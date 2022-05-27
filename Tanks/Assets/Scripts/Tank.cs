using UnityEngine;

public class Tank : MonoBehaviour
{
    public MovementFactory movementFactory;
    public IMovement Movement;

    public Rigidbody rb;
    
    public void OnInputChanged(float[] input)
    {
        Movement.Move(input, rb);
    }
    
    public void ChangeMovement<T>() where T : MonoBehaviour
    {
        Movement = (IMovement)MovementFactory.Create<T>();
    }
}

