using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterReferencer : MonoBehaviour
{
    public RollInitiatives RIScript;

    public InputField healthIF;

    public GameObject initPanel;
    public GameObject basePanel;

    public GameObject CharacterHealth;
    public GameObject CharacterArmorClass;
    public GameObject CharacterStrength;
    public GameObject CharacterDexterity;
    public GameObject CharacterConstitution;
    public GameObject CharacterWisdom;
    public GameObject CharacterInitiative;
    public GameObject CharacterName;

    public int CharacterHealthNum;
    public int CharacterArmorClassNum;
    public int CharacterStrengthNum;
    public int CharacterDexterityNum;
    public int CharacterConstitutionNum;
    public int CharacterWisdomNum;
    public int CharacterInitiativeNum;

    public bool addToList;
    // Start is called before the first frame update
    void Start()
    {
        healthIF.contentType = InputField.ContentType.IntegerNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (RIScript == null)
        {
            RIScript = GameObject.FindObjectOfType<RollInitiatives>();
        }

        if (!addToList && RIScript)
        {
            RIScript.Characters.Add(this);
            addToList = true;
        }

        CharacterHealth.GetComponent<TextMeshProUGUI>().text = CharacterHealthNum.ToString();
        CharacterArmorClass.GetComponent<TextMeshProUGUI>().text = CharacterArmorClassNum.ToString();
        CharacterStrength.GetComponent<TextMeshProUGUI>().text = CharacterStrengthNum.ToString();
        CharacterDexterity.GetComponent<TextMeshProUGUI>().text = CharacterDexterityNum.ToString();
        CharacterConstitution.GetComponent<TextMeshProUGUI>().text = CharacterConstitutionNum.ToString();
        CharacterWisdom.GetComponent<TextMeshProUGUI>().text = CharacterWisdomNum.ToString();
        CharacterInitiative.GetComponent<TextMeshProUGUI>().text = CharacterInitiativeNum.ToString();
    }

    public void ReduceHealth()
    {
        CharacterHealthNum -= int.Parse(healthIF.text);
    }
    public void IncreaseHealth()
    {
        CharacterHealthNum += int.Parse(healthIF.text);
    }

    public void CharacterStatsRoll(int CT)
    {
        if (CT == 1) // Asgardian Ranged
        {
            this.gameObject.name = "Asgardian Ranged";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Asgardian Ranged";
            CharacterHealthNum = Random.Range(1, 6) + 4;

            CharacterArmorClassNum = 10;
            CharacterConstitutionNum = 10;
            CharacterDexterityNum = Random.Range(9, 12);
            CharacterWisdomNum = Random.Range(9, 12);
            CharacterStrengthNum = 10;
        }

        if (CT == 2) // Asgardian Melee
        {
            this.gameObject.name = "Asgardian Melee";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Asgardian Melee";
            CharacterHealthNum = Random.Range(1, 6) + 4;

            CharacterArmorClassNum = 10;
            CharacterConstitutionNum = Random.Range(9, 12);
            CharacterDexterityNum = Random.Range(9, 12);
            CharacterWisdomNum = 10;
            CharacterStrengthNum = 10;
        }
        if (CT == 3) // Giant Ranged
        {
            this.gameObject.name = "Giant Ranged";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Giant Ranged";
            CharacterHealthNum = Random.Range(1, 8) + 6;

            CharacterArmorClassNum = Random.Range(10, 12);
            CharacterConstitutionNum = 12;
            CharacterDexterityNum = Random.Range(12, 14);
            CharacterWisdomNum = Random.Range(12, 14);
            CharacterStrengthNum = 12;
        }

        if (CT == 4) // Giant Melee
        {
            this.gameObject.name = "Giant Melee";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Giant Melee";
            CharacterHealthNum = Random.Range(1, 8) + 6;

            CharacterArmorClassNum = Random.Range(10, 12);
            CharacterConstitutionNum = Random.Range(12, 14);
            CharacterDexterityNum = Random.Range(12, 14);
            CharacterWisdomNum = 12;
            CharacterStrengthNum = 12;
        }

        if (CT == 5) // Odin Warrior
        {
            this.gameObject.name = "ODIN WARRIOR";
            Debug.Log("ODIN WARRIOR");
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Odin Warrior";
            CharacterHealthNum = 15;

            CharacterArmorClassNum = 12;
            CharacterConstitutionNum = 12;
            CharacterDexterityNum = 12;
            CharacterWisdomNum = 12;
            CharacterStrengthNum = 14;
        }

        if (CT == 6) // Odin Mage
        {
            this.gameObject.name = "ODIN Mage";
            Debug.Log("ODIN Mage");
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Odin Mage";
            CharacterHealthNum = 15;

            CharacterArmorClassNum = 12;
            CharacterConstitutionNum = 12;
            CharacterDexterityNum = 12;
            CharacterWisdomNum = 14;
            CharacterStrengthNum = 12;
        }

        if (CT == 7) // Odin Rogue
        {
            this.gameObject.name = "ODIN Rogue";
            Debug.Log("ODIN Rogue");
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Odin Rogue";
            CharacterHealthNum = 15;

            CharacterArmorClassNum = 12;
            CharacterConstitutionNum = 12;
            CharacterDexterityNum = 14;
            CharacterWisdomNum = 12;
            CharacterStrengthNum = 12;
        }

        if (CT == 8) // Hugin
        {
            this.gameObject.name = "Hugin";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Hugin";
            CharacterHealthNum = 10;

            CharacterArmorClassNum = 8;
            CharacterConstitutionNum = 8;
            CharacterDexterityNum = 14;
            CharacterWisdomNum = 12;
            CharacterStrengthNum = 2;
        }

        if (CT == 9) // Munin
        {
            this.gameObject.name = "Munin";
            CharacterName.GetComponent<TextMeshProUGUI>().text = "Munin";
            CharacterHealthNum = 10;

            CharacterArmorClassNum = 8;
            CharacterConstitutionNum = 8;
            CharacterDexterityNum =14;
            CharacterWisdomNum = 12;
            CharacterStrengthNum = 2;
        }
    }
}
