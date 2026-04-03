using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //This should be a weird quiz

    //List of UI
    public TMP_Text Description;
    public TMP_Text Text0;
    public TMP_Text Text1;
    public TMP_Text Text2;

    public Option CurrentOption;
    public Option StartOption;

    public GameObject Option0Button;
    public GameObject Option1Button;
    public GameObject Option2Button;
    public GameObject BackButton;

    public static GameManager instance;
    


    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("Current Option: " + StartOption);

        StartOption.UpdateOptionDisplay(this);

        CurrentOption = StartOption;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShiftOption(int Option)
    {
        switch(Option)
        {
            case 0:
                if (CurrentOption.Option0 != null)
                    CurrentOption.Option0.Back = CurrentOption;
                    CurrentOption = CurrentOption.Option0;
                break;

            case 1:
                if (CurrentOption.Option1 != null)
                        CurrentOption.Option1.Back = CurrentOption;
                        CurrentOption = CurrentOption.Option1;
                break;

            case 2:
                if (CurrentOption.Option2 != null)
                    CurrentOption.Option2.Back = CurrentOption;
                    CurrentOption = CurrentOption.Option2;
                break;

            case 3:
                if (CurrentOption.Back != null) 
                    CurrentOption = CurrentOption.Back;
                break;

        }

        CurrentOption.UpdateOptionDisplay(this);
    }
}
