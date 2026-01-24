using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject siluetpanel;

    public GameObject aquairopanel;
    public GameObject resumepanelaquairo;
    public GameObject statsaquairo;

    public GameObject mlmenangpanel;
    public GameObject resumepanelmlmenang;
    public GameObject statsmlmenang;

    public GameObject mlkalahpanel;
    public GameObject resumepanelmlkalah;
    public GameObject statsmlkalah;

    public GameObject masjidrobloxpanel;
    public GameObject resumepanelmasjidroblox;
    public GameObject statsmasjidroblox;

    public GameObject gimjamytpanel;
    public GameObject resumepanelgimjamyt;
    public GameObject statsgimjamyt;

    public GameObject robloxkembarpanel;
    public GameObject resumepanelrobloxkembar;
    public GameObject statsrobloxkembar;

    public GameObject robloxmvppanel;
    public GameObject resumepanelrobloxmvp;
    public GameObject statsrobloxmvp;

    public GameObject robloxgunungpanel;
    public GameObject resumepanelrobloxgunung;
    public GameObject statsrobloxgunung;

    public GameObject robloxdagingpanel;
    public GameObject resumepanelrobloxdaging;
    public GameObject statsrobloxdaging;

    public static string selectedNPC;

    void Start()
    {
        siluetpanel.SetActive(true);

        aquairopanel.SetActive(false);
        mlmenangpanel.SetActive(false);
        mlkalahpanel.SetActive(false);
        masjidrobloxpanel.SetActive(false);
        gimjamytpanel.SetActive(false);
        robloxkembarpanel.SetActive(false);
        robloxmvppanel.SetActive(false);
        robloxgunungpanel.SetActive(false);
        robloxdagingpanel.SetActive(false);
    }
    public void aquairobutton()
    {
        selectedNPC = "aquairo";

        siluetpanel.SetActive(false);
        aquairopanel.SetActive(true);

        resumepanelaquairo.SetActive(true);
        statsaquairo.SetActive(false);
    }

    public void detailaquairo()
    {
        resumepanelaquairo.SetActive(false);
        statsaquairo.SetActive(true);
    }
    public void mlmenangbutton()
    {
        selectedNPC = "mlmenang";

        siluetpanel.SetActive(false);
        mlmenangpanel.SetActive(true);

        resumepanelmlmenang.SetActive(true);
        statsmlmenang.SetActive(false);
    }

    public void detailmlmenang()
    {
        resumepanelmlmenang.SetActive(false);
        statsmlmenang.SetActive(true);
    }
    public void mlkalahbutton()
    {
        selectedNPC = "mlkalah";

        siluetpanel.SetActive(false);
        mlkalahpanel.SetActive(true);

        resumepanelmlkalah.SetActive(true);
        statsmlkalah.SetActive(false);
    }

    public void detailmlkalah()
    {
        resumepanelmlkalah.SetActive(false);
        statsmlkalah.SetActive(true);
    }
    public void masjidrobloxbutton()
    {
        selectedNPC = "masjidroblox";

        siluetpanel.SetActive(false);
        masjidrobloxpanel.SetActive(true);

        resumepanelmasjidroblox.SetActive(true);
        statsmasjidroblox.SetActive(false);
    }

    public void detailmasjidroblox()
    {
        resumepanelmasjidroblox.SetActive(false);
        statsmasjidroblox.SetActive(true);
    }
    public void gimjamytbutton()
    {
        selectedNPC = "gimjamyt";

        siluetpanel.SetActive(false);
        gimjamytpanel.SetActive(true);

        resumepanelgimjamyt.SetActive(true);
        statsgimjamyt.SetActive(false);
    }

    public void detailgimjamyt()
    {
        resumepanelgimjamyt.SetActive(false);
        statsgimjamyt.SetActive(true);
    }
    public void robloxkembarbutton()
    {
        selectedNPC = "robloxkembar";

        siluetpanel.SetActive(false);
        robloxkembarpanel.SetActive(true);

        resumepanelrobloxkembar.SetActive(true);
        statsrobloxkembar.SetActive(false);
    }

    public void detailrobloxkembar()
    {
        resumepanelrobloxkembar.SetActive(false);
        statsrobloxkembar.SetActive(true);
    }
    public void robloxmvpbutton()
    {
        selectedNPC = "robloxmvp";

        siluetpanel.SetActive(false);
        robloxmvppanel.SetActive(true);

        resumepanelrobloxmvp.SetActive(true);
        statsrobloxmvp.SetActive(false);
    }

    public void detailrobloxmvp()
    {
        resumepanelrobloxmvp.SetActive(false);
        statsrobloxmvp.SetActive(true);
    }
    public void robloxgunungbutton()
    {
        selectedNPC = "robloxgunung";

        siluetpanel.SetActive(false);
        robloxgunungpanel.SetActive(true);

        resumepanelrobloxgunung.SetActive(true);
        statsrobloxgunung.SetActive(false);
    }

    public void detailrobloxgunung()
    {
        resumepanelrobloxgunung.SetActive(false);
        statsrobloxgunung.SetActive(true);
    }
    public void robloxdagingbutton()
    {
        selectedNPC = "robloxdaging";

        siluetpanel.SetActive(false);
        robloxdagingpanel.SetActive(true);

        resumepanelrobloxdaging.SetActive(true);
        statsrobloxdaging.SetActive(false);
    }

    public void detailrobloxdaging()
    {
        resumepanelrobloxdaging.SetActive(false);
        statsrobloxdaging.SetActive(true);
    }
    public void kembali()
    {
        if (statsaquairo.activeSelf)
        {
            statsaquairo.SetActive(false);
            resumepanelaquairo.SetActive(true);
            return;
        }
        if (statsmlmenang.activeSelf)
        {
            statsmlmenang.SetActive(false);
            resumepanelmlmenang.SetActive(true);
            return;
        }
        if (statsmlkalah.activeSelf)
        {
            statsmlkalah.SetActive(false);
            resumepanelmlkalah.SetActive(true);
            return;
        }
        if (statsmasjidroblox.activeSelf)
        {
            statsmasjidroblox.SetActive(false);
            resumepanelmasjidroblox.SetActive(true);
            return;
        }
        if (statsgimjamyt.activeSelf)
        {
            statsgimjamyt.SetActive(false);
            resumepanelgimjamyt.SetActive(true);
            return;
        }
        if (statsrobloxkembar.activeSelf)
        {
            statsrobloxkembar.SetActive(false);
            resumepanelrobloxkembar.SetActive(true);
            return;
        }
        if (statsrobloxmvp.activeSelf)
        {
            statsrobloxmvp.SetActive(false);
            resumepanelrobloxmvp.SetActive(true);
            return;
        }
        if (statsrobloxgunung.activeSelf)
        {
            statsrobloxgunung.SetActive(false);
            resumepanelrobloxgunung.SetActive(true);
            return;
        }
        if (statsrobloxdaging.activeSelf)
        {
            statsrobloxdaging.SetActive(false);
            resumepanelrobloxdaging.SetActive(true);
            return;
        }
        siluetpanel.SetActive(true);
        aquairopanel.SetActive(false);
        mlmenangpanel.SetActive(false);
        mlkalahpanel.SetActive(false);
        masjidrobloxpanel.SetActive(false);
        gimjamytpanel.SetActive(false);
        robloxkembarpanel.SetActive(false);
        robloxmvppanel.SetActive(false);
        robloxgunungpanel.SetActive(false);
        robloxdagingpanel.SetActive(false);
    }
}
