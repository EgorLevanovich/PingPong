using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    private GameObject[] _characters;
    private int _index;

    public const string SkinKey = "CharacterSelected";

    private void Start()
    {
        _index = PlayerPrefs.GetInt(SkinKey);
       
        _characters = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            _characters[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in _characters)
        {
            go.SetActive(false);
        }
        
        if (_characters[_index])
        {
            _characters[_index].SetActive(true);
        }
    }

    public void SelectLeft()
    {
        _characters[_index].SetActive(false);
        _index--;
        if (_index < 0)
        {
            _index = _characters.Length - 1;
        }
        _characters[_index].SetActive(true);
        
        Save();
    }

    public void SelectRight()
    {
        _characters[_index].SetActive(false);
        _index++;
        if (_index == _characters.Length)
        {
            _index = 0;
        }
        _characters[_index].SetActive(true);
        
        Save();
    }

    private void Save()
    {
        Debug.Log($"{_index} {_characters.Length}");
        PlayerPrefs.SetInt(SkinKey, _index);
    }
}
