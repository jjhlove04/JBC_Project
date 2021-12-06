using DG.Tweening;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField][Tooltip("베이스 카드의 스프라이트 랜더러")] SpriteRenderer card;
    [SerializeField][Tooltip("스킬의 이미지")] SpriteRenderer skillImage;
    [SerializeField][Tooltip("스킬카드의 이름")]TMP_Text nameTMP;
    [SerializeField][Tooltip("데미지 텍스트")]TMP_Text damageTMP;
    [SerializeField][Tooltip("카드 비용 텍스트")]TMP_Text costTMP;
    [SerializeField][Tooltip("카드 앞면")] Sprite cardFront;
    [SerializeField][Tooltip("카드 뒷면")] Sprite cardback;

    
    public Item item;
    bool isFront;
    //public PRS originPRS;

    public void Setup(Item item, bool isFront)
    {
        this.item = item;
        this.isFront = isFront;
        if (this.isFront)
        {
            skillImage.sprite = this.item.CardImage;
            nameTMP.text = this.item.name;
            costTMP.text = this.item.cost.ToString();
            damageTMP.text = this.item.damage.ToString();
        }
        else
        {
            card.sprite = cardback;
            nameTMP.text = "";
            damageTMP.text = "";
            costTMP.text = "";
        }
    }

    public void CheckCard()
    {

    }

    public void MoveTransform(/*PRS prs*/ bool useDotween, float dotweenTime = 0)
    {
        // if (useDotween)
        // {
        //     transform.DOMove(prs.pos, dotweenTime);
        //     transform.DORotateQuaternion(prs.rot, dotweenTime);
        //     transform.DOScale(prs.scale, dotweenTime);
        // }
        // else
        // {
        //     transform.position = prs.pos;
        //     transform.rotation = prs.rot;
        //     transform.localScale = prs.scale;
        // }
    }

    void Start()
    {

    }


    void Update()
    {

    }
    void OnMouseDown()
    {
        if (isFront)
        {

        }
            //CardManager.Inst.CardMouseDown();
    }

    void OnMouseUp()
    {
        if (isFront)
        {

        }
            //CardManager.Inst.CardMouseUp();
    }
    void OnMouseOver()
    {
        if (isFront)
        {
            
            //CardManager.Inst.CardMouseOver(this);
        }
    }
    void OnMouseExit()
    {
        
           // CardManager.Inst.CardMouseExit(this);
    }
}
