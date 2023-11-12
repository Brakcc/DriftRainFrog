using UnityEngine;
using UnityEngine.UI;

public class FirstSelect : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Button>().Select();
    }
}
