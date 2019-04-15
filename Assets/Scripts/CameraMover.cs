using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private BlockSpawner spawner;

    public float Speed;

    public int Range;
	// Use this for initialization
	void Start ()
	{
	    this.spawner = this.GetComponent<BlockSpawner>();
	}

	// Update is called once per frame
	void Update ()
	{

	    var offset = this.gameObject.transform.position.y - this.spawner.AllBlocks.Count * this.spawner.LeftBlock.GetComponent<BoxCollider>().size.y;

        if(offset < this.Range)
        {
            this.transform.Translate(0, Time.deltaTime * this.Speed, 0, Space.World);
        }
	}
}
