using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Vector2Int size;
    public Vector2 offset;
    public GameObject brickPrefab;

    private void Awake()
    {
        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject newB = Instantiate(brickPrefab, transform);
                newB.transform.position = transform.position + new Vector3((float)((size.x - 1) * .5f - i) * offset.x, j * offset.y, 0);
            }

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
