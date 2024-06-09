using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text uiText;
    public Text uiT;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (PlayerMove.Getitem)
        {
            uiText.text = "������ ȹ�� : �Ϸ�!";
        }

        if (PlayerMove.Finish)
        {
            uiT.text = "���� : �Ϸ�!";
        }
    }
}
