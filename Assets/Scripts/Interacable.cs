using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interacable : MonoBehaviour
{
    //thêm hay xóa các sự kiện tương tác của vật thễ
    public bool useEvent;

    //hiện tin nhắn khi tới gần vật có thể tương tác
    public string promptMessage;
    //hàm được sử dụng bởi player
    //https://dotnettutorials.net/lesson/template-method-design-pattern/ link đọc thêm
    public void BaseIneract()
    {
        if(useEvent)
            GetComponent<interactionEvent>().OnInteract.Invoke();
        Intercact();
    }
    protected virtual void Intercact()
    {
        //không code nào được viết ở dây
        //sẽ được viết lại bởi các hàm phụ khác
    }
    
}
