using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Uimisso2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;// đối tượng TextMeshPro 

    public float typingSpeed = 1f;// Tốc độ gõ chữ (giây/ký tự)

    public float timeUntilHide = 3.0f; // Thời gian chữ tồn tại trên màn hình SAU KHI gõ xong

    public AudioSource typingSound;  //  Âm thanh khi gõ chữ

    [TextArea(3, 5)]
    public string sentence;
    void Start()
    {
        // Bắt đầu Coroutine để hiển thị chữ
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ShowText()
    {
       
        // Đảm bảo text đang trống và được kích hoạt
        textDisplay.text = "";
        textDisplay.gameObject.SetActive(true);
        // Vòng lặp chạy trong kí tự chuỗi 'sentence' 
        foreach (char letter in sentence.ToCharArray())
        {
            textDisplay.text += letter; // Thêm từng ký tự vào text hiển thị
            typingSound.Play();
            yield return new WaitForSeconds(typingSpeed); // Chờ một khoảng thời gian ngắn
        }



        yield return new WaitForSeconds(timeUntilHide);// Sau khi gõ xong, chờ thêm vài giây

        textDisplay.gameObject.SetActive(false); // Sau đó ẩn đối tượng text đi
    }
}
