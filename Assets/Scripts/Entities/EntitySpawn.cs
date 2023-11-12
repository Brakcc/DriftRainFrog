using UnityEngine;

public class EntitySpawn : MonoBehaviour
{
    #region fields
    [SerializeField] GameObject obj;
    [SerializeField] float waitTime;
    float cursor;
    [SerializeField] float ySpawnPos;
    [SerializeField] float minXSpawnPos;
    [SerializeField] float maxXSpawnPos;
    public float bonusSpeed;
    [SerializeField] Transform parent;
    #endregion

    #region methodes
    void Start()
    {
        cursor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cursor += Time.deltaTime;
        if (cursor > waitTime)
        {
            cursor = 0;
            GameObject temp = Instantiate(obj, parent);
            Vector2 pos = new(Mathf.Lerp(minXSpawnPos, maxXSpawnPos, Random.value), ySpawnPos);
            temp.transform.position = pos;
            temp.GetComponent<AEntity>().ZoneSpeed = bonusSpeed;
        }
    }
    #endregion
}
