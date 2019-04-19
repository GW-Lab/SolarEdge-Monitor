# SolarEdge-Monitor
SolarEdge-Inverter Monitoring via SolarEdge API (SolarEdge Website)
This small VB.NET program is for live monitoring* your SolarEdge-Inverter on the desktop of a Windows PC.

Program: VB.NET Winforms .Net framwork 4.7.2 .Net JSON

Devices: SolarEdge-inverter Iungo Energy manager
Protocols: TCP/IP

API: ModBus via TCP/IP Iungo JSON

The live Inverter information:
Power in Watt
Voltage to the grid
Ampere to the grid
Internal temperature in Celcius
Daily yield in kWh
Total yield (from commissioning date) in MWh

To use the the program you have to Generate the access-key on your SolarEdge Website and replace "SolarEdgeKey" string
ReadOnly siteKey As String = "SolarEdgeKey" ' SolarEdge generated access Key

For people that are intrerested in domotica: There is also the posibility to monitor live the power usages of your home via the Iungo-Energy-manager (https://www.iungo.nl/nl/) and operate some ZWave switches to power a electrical devices.
How to use Iungo ZWave switches:
Me.iungo = New IungoClient(Net.IPAddress.Parse(My.Settings.IP_Iungo))
Me.iungo.ZWave.PowerSwitches("Iungo-switch-Name").State = PowerSwitch.PowerSwitchStatus.Off

* (5 minute interval)
