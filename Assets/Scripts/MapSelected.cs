using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelected : MonoBehaviour
{
    [SerializeField] private SceneAsset _gameplayScene;
    
    private GameObject[] characters;
    private int _index;

    private void Start()
    {
        _index = PlayerPrefs.GetInt("MapSelected");
        characters = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characters[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }

        if (characters[_index])
        {
            characters[_index].SetActive(true);
        }
    }

    public void SelectLeft()
    {
        characters[_index].SetActive(false);
        _index--;
        if (_index < 0)
        {
            _index = characters.Length - 1;
        }
        characters[_index].SetActive(true);
    }

    public void SelectRight()
    {
        characters[_index].SetActive(false);
        _index++;
        if (_index == characters.Length)
        {
            _index = 0;
        }
        characters[_index].SetActive(true);
    }

    public void StartScene()
    {
        PlayerPrefs.SetInt("MapSelected", _index);
        SceneManager.LoadScene(_gameplayScene.name);
    }
}
