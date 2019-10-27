using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollInitiatives : MonoBehaviour
{
    public List<CharacterReferencer> Characters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReOrder()
    {
        for (int i = 0; i < Characters.Count; i++)
        {
            for (int x = 0; x < Characters.Count; x++)
            {
                if (Characters[i].CharacterInitiativeNum > Characters[x].CharacterInitiativeNum)
                {
                    var temp = Characters[x];
                    Characters[x] = Characters[i];
                    Characters[i] = temp;
                }
            }
        }

        for (int i = 0; i < Characters.Count; i++)
        {
            Characters[i].transform.SetSiblingIndex(i);
        }
    }

    public void Begin()
    {
        for (int i = 0; i < Characters.Count; i++)
        {
            Characters[i].initPanel.SetActive(false);
            Characters[i].basePanel.SetActive(true);
        }
    }

    public void RollAll()
    {
        for (int i = 0; i < Characters.Count; i++)
        {
            Characters[i].CharacterInitiativeNum = Random.Range(1, 20);
        }
        ReOrder();
    }
}
