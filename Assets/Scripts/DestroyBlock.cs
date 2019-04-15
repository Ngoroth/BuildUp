using UnityEngine;

public class DestroyBlock : MonoBehaviour
{

    private BlockSpawner spawner;

    void Start()
    {
        this.spawner = Camera.main.GetComponent<BlockSpawner>();
    }

    void OnCollisionEnter(Collision collision)
    {
        this.spawner.AllBlocks.Remove(collision.gameObject.GetComponent<Block>());
        Destroy(collision.gameObject);
    }
}
