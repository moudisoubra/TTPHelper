using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCharacters : MonoBehaviour
{
    public GameObject prefab;
    public int characterCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateCharacter(int type)
    {
        InstantiateCharacter(type);
        Debug.Log(type);
    }

    public void InstantiateCharacter(int type)
    {
        GameObject temp = Instantiate(prefab, transform);
        temp.GetComponent<CharacterReferencer>().CharacterStatsRoll(type);
        temp.transform.position += new Vector3 (0, 150 * characterCount, 0);
        temp = null;
        characterCount++;
    }
}
