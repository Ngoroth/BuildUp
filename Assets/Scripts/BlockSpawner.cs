using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject LeftBlock;

    public GameObject RightBlock;

    public List<Block> AllBlocks;

    public GameObject Basement;

    public Material BasementMaterial;

    public bool GameOver;

    public bool NeedBlock
    {
        get
        {
            return !this.GameOver && this.AllBlocks.All(b => b.IsDropped);
        }
    }

	// Use this for initialization
	void Start () {
		this.AllBlocks = new List<Block>(100);
        this.Basement = GameObject.CreatePrimitive(PrimitiveType.Cube);
	    this.Basement.transform.localScale = new Vector3(Random.value * 10, 1, Random.value * 10);
	    this.Basement.GetComponent<MeshRenderer>().material = this.BasementMaterial;
	    this.Basement.tag = "Basement";
	}
	
	// Update is called once per frame
	void Update () {
	    if (!this.NeedBlock)
	    {
	        return;
	    }

	    var currentBlock = this.AllBlocks.Count % 2 == 0 ? this.LeftBlock : this.RightBlock;

	    var newPosition = new Vector3(currentBlock.transform.position.x,
	                                  currentBlock.transform.position.y + currentBlock.GetComponent<BoxCollider>().size.y * this.AllBlocks.Count,
	                                  currentBlock.transform.position.z);

	    var block = Instantiate(currentBlock,
	                            newPosition,
	                            currentBlock.transform.rotation);
	    this.AllBlocks.Add(block.GetComponent<Block>());
	}
}
