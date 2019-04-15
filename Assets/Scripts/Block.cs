using UnityEngine;

public class Block : MonoBehaviour
{
    public float Speed;
    public Vector3 Direction;
    public bool IsDropped;

	void Update () 
	{
	    if (this.IsDropped)
	    {
            return;
	    }
        this.gameObject.GetComponent<Rigidbody>().AddForce(this.Direction*this.Speed);
	}
}
