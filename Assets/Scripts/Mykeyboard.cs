using UnityEngine;

public class MyKeyboard : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public TMPro.TextMeshProUGUI showText;
    public VRController Client;

    public void Add(string s)
    {
        text.text = text.text += s;
    }

    public void Remove()
    {
        text.text = text.text.Remove(text.text.Length - 1);
    }

    public void RefreshIP()
    {
        Client.RefreshIP(text.text);
    }

    public void SwitchLRController()
    {
        Client.LRinverse = !Client.LRinverse;
    }
}
