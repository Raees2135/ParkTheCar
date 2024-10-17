using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarSpeedText : MonoBehaviour
{
    public TextMeshProUGUI carSpeed;
    public Rigidbody car;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody>();
        carSpeed = GameObject.Find("SpeedText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        carSpeed.text = (car.velocity.magnitude * 2.23693629f).ToString("0");
    }
}
