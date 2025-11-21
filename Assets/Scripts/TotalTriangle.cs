using UnityEngine;

public class TotalTriangle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TMPro.TextMeshProUGUI textBox;
    public int triangleCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Count: " + triangleCount.ToString();
    }

    public void MoreTriangle(int number)
    {
        triangleCount += number;
    }
}
