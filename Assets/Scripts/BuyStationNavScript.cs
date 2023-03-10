using UnityEngine;

public class BuyStationNavScript : MonoBehaviour
{
    [SerializeField]
    private GameObject shop, upgrade, shopButton, upgradeButton;

    private void Start()
    {
        OnShopButtonClick();
    }

    public void OnShopButtonClick()
    {
        shop.SetActive(true);
        upgrade.SetActive(false);
    }

    public void OnUpgradeButtonClick()
    {
        shop.SetActive(false);
        upgrade.SetActive(true);
    }

}
