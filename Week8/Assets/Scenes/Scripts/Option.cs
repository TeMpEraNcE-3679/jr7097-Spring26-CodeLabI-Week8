using UnityEngine;

[CreateAssetMenu(fileName = "Option", menuName = "Scriptable Objects/Options")]
public class Option : ScriptableObject
{
    public string description;
    public string Option0Text;
    public string Option1Text;
    public string Option2Text;

    public Option Option0;
    public Option Option1;
    public Option Option2;
    public Option Back;

    //private void OnValidate()
    //{
    //    if (GameManager.instance != null)
    //    { 
    //     UpdateOptionDisplay(GameManager.instance);
    //    }
    //
    //
    //}

    public void UpdateOptionDisplay(GameManager gm)
    {
        gm.Description.text = description;
        gm.Text0.text = Option0Text;
        gm.Text1.text = Option1Text;
        gm.Text2.text = Option2Text;

        gm.BackButton.SetActive(Back != null);
        gm.Option0Button.SetActive(Option0 != null);
        gm.Option1Button.SetActive(Option1 != null);
        gm.Option2Button.SetActive(Option2 != null);
    }
}
