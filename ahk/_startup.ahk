; #Warn                        ;  Enable warnings to assist with detecting common errors.
SendMode("Input")              ;  Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir(A_ScriptDir)     ;  Ensures a consistent starting directory.
#SingleInstance force
Persistent

ChangeLayerIcon("KBD")

; Notifications
#Include "_layer.ahk"

; Help
#Include "_help.ahk"
