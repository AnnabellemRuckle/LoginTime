using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegisterUser : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public TMP_InputField PasswordConfirmationInput;
    public Button RegisterUserButton;

    void Start()
    {
        RegisterUserButton.onClick.AddListener(() => {
            if (PasswordInput.text != PasswordConfirmationInput.text)
            {
                Debug.LogError("Error: Password and Confirmatio do not match!");
                return; 
            }

            StartCoroutine(Main.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text));
        });
    }
}
