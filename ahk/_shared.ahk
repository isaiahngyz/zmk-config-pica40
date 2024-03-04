ChangeLayerIcon(lyr)
{
    ico := lyr ".png"

    if (lyr = "KBD") {
        msg := "Waiting..."
    } else {
        msg := lyr . " Layer"
    }

    if FileExist(ico) {
        TraySetIcon(ico)
        A_IconTip := msg
    } else {
        TraySetIcon("*")
        A_IconTip := "Waiting..."
    }
}

ShowHelp(lyr)
{
    showGui := Gui()
    showGui.Hide()

    img := lyr ".png"
    height := 390
    width := 1150

    showGui.Opt("-Caption +LastFound +ToolWindow") ; +ToolWindow avoids a taskbar button and an alt-tab menu item.
    showGui.BackColor := "030303"
    WinSetTransColor("030303", showGui)
    showGui.MarginX := "0", showGui.MarginY := "0"
    showGui.Add("Picture", "w" . width . " h" . height, img)
    showGui.Show("w" . width . " h" . height . " xCenter yCenter")
    WinSetAlwaysOnTop()
    WinSetRegion("0-0 w" width " h" height " R15-15")
    ; WinSet, transparent, 200

    showGui.OnEvent("Close", Close)
    showGui.OnEvent("Escape", Close)

    Close(*)
    {
        showGui.Destroy()  ; Destroy the about box.
    }
}
