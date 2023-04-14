using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public List<string> MutualDestructionTags;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        
        if(MutualDestructionTags.Contains(other.gameObject.tag))
        {
            Debug.Log($"Destroying object: {other.gameObject.name} from object {gameObject.name}");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
