using UnityEngine;

public class InputManager : MonoBehaviour 
{

	void Update ()
	{
	    this.onClick();
	}

    private void onClick()
    {
        RaycastHit hit;

        if (!Physics.Raycast(this.gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition), out hit) 
            || !Input.GetMouseButtonDown(0)
            || null == hit.rigidbody
            || null == hit.rigidbody.gameObject?.GetComponent<Block>())
        {
            return;
        }

        hit.rigidbody.constraints = RigidbodyConstraints.None;
        hit.rigidbody.gameObject.GetComponent<Block>().IsDropped = true;

    }
}
